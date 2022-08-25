import { Injectable } from '@angular/core';
import { User } from 'src/models/Entities/user';
import { JwtService } from './jwt.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private jwtService: JwtService) { }

  public getUser() {
    const accessToken = JSON.parse(localStorage.getItem('accessToken')!);

    if (accessToken)
    {
      
      let info : any = this.jwtService.DecodeToken(accessToken);
      let user = {} as User;
      user.email = info.email;
      user.id = info.userId;
      return user;
    }
    return null;
  }
}