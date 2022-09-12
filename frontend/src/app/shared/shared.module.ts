import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FungLogoComponent } from './fung-logo/fung-logo.component';
import { FungButtonComponent } from './fung-button/fung-button.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FungInputComponent } from './fung-input/fung-input.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FungSideBarComponent } from './fung-side-bar/fung-side-bar.component';
import { FungSpinnerComponent } from './fung-spinner/fung-spinner.component';
import { TimeFromUpdatePipe } from '../pipes/time-from-update.pipe';
import { DensityPipe } from '../pipes/density.pipe';
import { FungButtonIconComponent } from './fung-button-icon/fung-button-icon.component';
import { VolumePipe } from '../pipes/volume.pipe';
import { MaterialModule } from '../material/material.module';
import { FungDropdownComponent } from './fung-dropdown/fung-dropdown.component';
import { ClickOutsideDirective } from '../directives/click-outside.directive';



@NgModule({
  declarations: [
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent,
    FungSideBarComponent,
    FungSpinnerComponent,
    TimeFromUpdatePipe,
    DensityPipe,
    FungButtonIconComponent,
    VolumePipe,
    FungDropdownComponent,
    ClickOutsideDirective
  ],
  imports: [
    FontAwesomeModule,
    CommonModule,
    RouterModule,
    FormsModule,
    MaterialModule
  ],
  exports: [
    RouterModule,
    FontAwesomeModule,
    FungLogoComponent,
    FungButtonComponent,
    FungInputComponent,
    FormsModule,
    FungSideBarComponent,
    FungSpinnerComponent,
    TimeFromUpdatePipe,
    DensityPipe,
    FungButtonIconComponent,
    VolumePipe,
    MaterialModule,
    FungDropdownComponent
  ]

})
export class SharedModule { }
