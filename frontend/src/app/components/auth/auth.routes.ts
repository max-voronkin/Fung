import { Routes } from '@angular/router';
import { LoginGuard } from 'src/app/guards/login.guard';
import { AuthPageComponent } from './auth-page/auth-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { RegisterPageComponent } from './register-page/register-page.component';

export const AuthRoutes: Routes = [
  {
    path: 'auth',
    component: AuthPageComponent,
    children: [
      { path: 'register', component: RegisterPageComponent, canActivate: [LoginGuard]},
      { path: 'login', component: LoginPageComponent, canActivate: [LoginGuard]}
    ],
  },
];
