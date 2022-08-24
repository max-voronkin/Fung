import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }

  public getUser() {
    const accessToken = JSON.parse(localStorage.getItem('accessToken')!);

    if (accessToken)
    {
      return accessToken;
    }
  }
}
