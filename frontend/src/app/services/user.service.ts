import { Injectable } from '@angular/core';
import { UserChangePasswordDTO } from 'src/models/DTO/User/user-changePasswordDTO';
import { User } from 'src/models/Entities/user';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpService: HttpService) { }

  public routePrefix = '/api/user';

  public updatePassword(payload: UserChangePasswordDTO) {
    return this.httpService.putFullRequest<void>(`${this.routePrefix}/updatePassword`, payload);
  }

  public getUserFromToken() {
    return this.httpService.getFullRequest<User>(`${this.routePrefix}/fromToken`);
  }
}
