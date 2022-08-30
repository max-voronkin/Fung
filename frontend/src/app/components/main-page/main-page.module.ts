import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StationsPageComponent } from './stations-page/stations-page.component';
import { MainPageOverlayComponent } from './main-page-overlay/main-page-overlay.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { TankInfoComponent } from './components/tank-info/tank-info.component';
import { StationInfoComponent } from './components/station-info/station-info.component';



@NgModule({
  declarations: [
    StationsPageComponent,
    MainPageOverlayComponent,
    TankInfoComponent,
    StationInfoComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class MainPageModule { }
