import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { catchError, Observable, switchMap, throwError } from 'rxjs';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';
import { ErrorCode } from 'src/models/enums/error-code';
import { ErrorNotificationService } from '../error-notification.service';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
    constructor(private router: Router, private authService: AuthService, private errorNotification: ErrorNotificationService) {}

    public intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
      return next.handle(req).pipe(
        catchError((response) => {
          if (response.status === 401) {
            if (response.headers.has('Token-Expired')) {
              return this.authService.refreshToken().pipe(
                switchMap((resp) => {
                  req = req.clone({
                    setHeaders: { Authorization: `Bearer ${resp.accessToken}`}
                  });
                  
                  return next.handle(req);
                })
              )
            }

            if (response.error) {
              if (response.error.errorCode === ErrorCode.InvalidToken && !this.authService.isAccessTokenExist()) {
                return throwError(response.error.error);
              }
              if (response.error.errorCode === ErrorCode.ExpiredRefreshToken) {
                this.router.navigate(['/auth']);
                this.authService.logout();
                return throwError(response.error.errorCode);
              }
            }
          }

          console.log(response);
          const error = response.error
              ? response.error.error || response.error.message
              : response.message || `${response.status} ${response.statusText}`;

          this.errorNotification.showErrorMessage(error);

          return throwError(error);

        }

        )

      );

    }
}
