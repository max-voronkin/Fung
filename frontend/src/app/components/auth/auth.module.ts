import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterPageComponent } from './register-page/register-page.component';
import { AuthPageComponent } from './auth-page/auth-page.component';



@NgModule({
  declarations: [
    RegisterPageComponent,
    AuthPageComponent
  ],
  imports: [
    CommonModule
  ]
})
export class AuthModule { }
