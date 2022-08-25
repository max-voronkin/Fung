import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FungLogoComponent } from './fung-logo/fung-logo.component';
import { FungButtonComponent } from './fung-button/fung-button.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FungInputComponent } from './fung-input/fung-input.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FungSideBarComponent } from './fung-side-bar/fung-side-bar.component';



@NgModule({
  declarations: [
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent,
    FungSideBarComponent
  ],
  imports: [
    FontAwesomeModule,
    CommonModule,
    RouterModule,
    FormsModule
  ],
  exports: [
    RouterModule,
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent,
    FormsModule,
    FungSideBarComponent
  ]

})
export class SharedModule { }
