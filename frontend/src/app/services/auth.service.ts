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
            this._setTokens(resp.body);  
            return true;
          }
          return false;
        })
    );
}

private _setTokens(tokens: AuthUserDTO) {
  if (tokens.accessToken) 
  {
    localStorage.setItem('accessToken', JSON.stringify(tokens.accessToken));      
  }
  if (tokens.refreshToken)
  {
    localStorage.setItem('refreshToken', JSON.stringify(tokens.refreshToken));
  }
}

  public register(user: UserRegisterDTO) {
    return this._handleAuthResponse(this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/register`, user));
  }

  public login(user: UserLoginDTO) {
    return this._handleAuthResponse(this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/login`, user));
  }

  public logout () {
    localStorage.removeItem('accessToken');
    localStorage.removeItem('refreshToken');
  }

  public isAccessTokenExist() {
    if (localStorage.getItem('accessToken') && localStorage.getItem('refreshToken'))
    {
      return true;
    }
    return false;
  }

  public refreshToken() {
    return this.httpService.postFullRequest<AuthUserDTO>(`${this.routePrefix}/refresh`, {
      accessToken: JSON.parse(localStorage.getItem('accessToken')!),
      refreshToken: JSON.parse(localStorage.getItem('refreshToken')!)
    })
    .pipe(
      map((resp) => {
        this._setTokens(resp.body!);
        return resp.body!;
      })
    );
  }
}
