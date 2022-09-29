import { Injectable } from '@angular/core';
import { User } from 'src/models/Entities/user';
import { HttpService } from './http.service';
import { JwtService } from './jwt.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private jwtService: JwtService, private httpService: HttpService) { }

  public routePrefix = '/api/user';

  // public getUser() {
  //   const accessToken = JSON.parse(localStorage.getItem('accessToken')!);

  //   if (accessToken)
  //   {
      
  //     let info : any = this.jwtService.DecodeToken(accessToken);
  //     let user = {} as User;
  //     user.email = info.email;
  //     user.id = info.userId;
  //     return user;
  //   }
  //   return null;
  // }

  public getUserFromToken() {
    return this.httpService.getFullRequest<User>(`${this.routePrefix}/fromToken`);
  }
}
