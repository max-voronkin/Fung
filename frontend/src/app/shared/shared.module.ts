import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FungLogoComponent } from './fung-logo/fung-logo.component';
import { FungButtonComponent } from './fung-button/fung-button.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FungInputComponent } from './fung-input/fung-input.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent
  ],
  imports: [
    FontAwesomeModule,
    CommonModule,
    RouterModule
  ],
  exports: [
    RouterModule,
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent
  ]

})
export class SharedModule { }
