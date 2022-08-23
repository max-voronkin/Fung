import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterPageComponent } from './register-page/register-page.component';
import { AuthPageComponent } from './auth-page/auth-page.component';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    RegisterPageComponent,
    AuthPageComponent
  ],
  imports: [
    CommonModule, SharedModule
  ]
})
export class AuthModule { }
