import { Routes } from '@angular/router';
import { AuthPageComponent } from './auth-page/auth-page.component';
import { RegisterPageComponent } from './register-page/register-page.component';

export const AuthRoutes: Routes = [
  {
    path: 'auth',
    component: AuthPageComponent,
    children: [
      { path: 'register', component: RegisterPageComponent}
    ],
  },
];
