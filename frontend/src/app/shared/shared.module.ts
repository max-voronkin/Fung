import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FungLogoComponent } from './fung-logo/fung-logo.component';
import { FungButtonComponent } from './fung-button/fung-button.component';



@NgModule({
  declarations: [
    FungLogoComponent,
    FungButtonComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    FungLogoComponent,
    FungButtonComponent
  ]

})
export class SharedModule { }
