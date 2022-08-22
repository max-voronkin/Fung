import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FungLogoComponent } from './fung-logo/fung-logo/fung-logo.component';



@NgModule({
  declarations: [
    FungLogoComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    FungLogoComponent
  ]

})
export class SharedModule { }
