import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterPageComponent } from './register-page/register-page.component';
import { AuthPageComponent } from './auth-page/auth-page.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { LoginPageComponent } from './login-page/login-page.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    RegisterPageComponent,
    AuthPageComponent,
    LoginPageComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ReactiveFormsModule
  ]
})
export class AuthModule { }
