import { HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { AuthUserDTO } from 'src/models/DTO/User/user-authDTO';
import { UserRegisterDTO } from 'src/models/DTO/User/user-registerDTO';
import { User } from 'src/models/Entities/user';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public routePrefix = '/api/auth';
  private user!: User;

  constructor(private httpService: HttpService) { }

  private _handleAuthResponse(observable: Observable<HttpResponse<AuthUserDTO>>) {
    return observable.pipe(
        map((resp) => {
          this._setTokens(resp.body!.token);           
          this.user = resp.body!.user;
          //this.eventService.userChanged(resp.body.user);
          return resp.body!.user;
        })
    );
}

private _setTokens(token: string) {
  if (token) {
      localStorage.setItem('accessToken', JSON.stringify(token));
      //this.getUser();
  }
}

  public register(user: UserRegisterDTO) {
    return this._handleAuthResponse(this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/register`, user));
  }
}
