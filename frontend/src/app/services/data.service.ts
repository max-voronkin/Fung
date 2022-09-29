import { Injectable } from '@angular/core';
import { map, of } from 'rxjs';
import { Settings } from 'src/models/Entities/settings';
import { User } from 'src/models/Entities/user';
import { SettingsService } from './settings.service';
import { UserService } from './user.service';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private user: User | undefined;
  private settings: Settings | undefined;

  constructor(private userService: UserService, private settingsService: SettingsService) { }

  public getUser() {
    return this.user
        ? of(this.user)
        : this.userService.getUserFromToken().pipe(
              map((resp) => {
                  this.user = resp.body!
                  return this.user;
              })
          );
  }

  public getSettings() {
    return this.settings
    ? of(this.settings)
    : this.settingsService.getSettingsFromToken().pipe(
          map((resp) => {
              this.settings = resp.body!
              return this.settings;
          })
      );
  }
  
  public updateSettings(newSettings: Settings): void {
    this.settings = newSettings;
  }

  public clear(): void {
    this.user = undefined;
    this.settings = undefined;
  }

  public get heightUnits() {
    return this.settings?.heightUnit;
  }

  public get volumeUnits() {
    return this.settings?.volumeUnit;
  }
}
