import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { SharedModule } from 'src/app/shared/shared.module';
import { SettingsPageComponent } from './settings-page/settings-page.component';
import { UserSettingsComponent } from './settings-components/user-settings/user-settings.component';
import { StationsSettingsComponent } from './settings-components/stations-settings/stations-settings.component';
import { UnitsSettingsComponent } from './settings-components/units-settings/units-settings.component';
import { SettingsMenuItemComponent } from './settings-components/settings-menu-item/settings-menu-item.component';



@NgModule({
  declarations: [
    SettingsPageComponent,
    UserSettingsComponent,
    StationsSettingsComponent,
    UnitsSettingsComponent,
    SettingsMenuItemComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class SettingsPageModule { }
