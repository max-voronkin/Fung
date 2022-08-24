import { HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { AuthUserDTO } from 'src/models/DTO/User/user-authDTO';
import { UserLoginDTO } from 'src/models/DTO/User/user-loginDTO';
import { UserRegisterDTO } from 'src/models/DTO/User/user-registerDTO';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public routePrefix = '/api/auth';

  constructor(private httpService: HttpService) { }

  private _handleAuthResponse(observable: Observable<HttpResponse<AuthUserDTO>>) {
    return observable.pipe(
        map((resp) => {
          if (resp.body)
          {
            this._setTokens(resp.body.accessToken, resp.body.refreshToken);  
            return true;
          }
          return false;
        })
    );
}

private _setTokens(access: string, refresh: string) {
  if (access) 
  {
    localStorage.setItem('accessToken', JSON.stringify(access));      
  }
  if (refresh)
  {
    localStorage.setItem('refreshToken', JSON.stringify(refresh));
  }
}

  public register(user: UserRegisterDTO) {
    return this._handleAuthResponse(this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/register`, user));
  }

  public login(user: UserLoginDTO) {
    return this._handleAuthResponse(this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/login`, user));
  }
}
