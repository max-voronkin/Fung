import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { SharedModule } from 'src/app/shared/shared.module';
import { SettingsPageComponent } from './settings-page/settings-page.component';
import { UserSettingsComponent } from './settings-components/user-settings/user-settings.component';
import { StationsSettingsComponent } from './settings-components/stations-settings/stations-settings.component';
import { UnitsSettingsComponent } from './settings-components/units-settings/units-settings.component';
import { SettingsMenuItemComponent } from './settings-components/settings-menu-item/settings-menu-item.component';
import { CreateStationDialogComponent } from './settings-components/create-station-dialog/create-station-dialog.component';
import { ReactiveFormsModule } from '@angular/forms';
import { StationInfoDialogComponent } from './settings-components/station-info-dialog/station-info-dialog.component';
import { HeightUnitsDialogComponent } from './settings-components/height-units-dialog/height-units-dialog.component';
import { VolumeUnitsDialogComponent } from './settings-components/volume-units-dialog/volume-units-dialog.component';



@NgModule({
  declarations: [
    SettingsPageComponent,
    UserSettingsComponent,
    StationsSettingsComponent,
    UnitsSettingsComponent,
    SettingsMenuItemComponent,
    CreateStationDialogComponent,
    StationInfoDialogComponent,
    HeightUnitsDialogComponent,
    VolumeUnitsDialogComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ReactiveFormsModule
  ]
})
export class SettingsPageModule { }
