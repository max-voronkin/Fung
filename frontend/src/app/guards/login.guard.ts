import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, CanActivateChild, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class LoginGuard implements CanActivate, CanActivateChild {

  constructor (private authService: AuthService, private router: Router) {
  }
  
  canActivate(
    route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    return this.checkToken(state);
  }
  
  canActivateChild(
    childRoute: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    return this.checkToken(state);
  }

  private checkToken(state: RouterStateSnapshot) {
    if (!this.authService.isAccessTokenExist()) 
    {
        return true;
    }
    this.router.navigate(['/stations']);
    return false;
}
  
}
