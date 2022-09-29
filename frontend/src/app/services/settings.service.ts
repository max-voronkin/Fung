import { Injectable } from '@angular/core';
import { Settings } from 'src/models/Entities/settings';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  public routePrefix = '/api/settings';

  constructor(private httpService: HttpService) { }

  public getSettingsFromToken() {
    return this.httpService.getFullRequest<Settings>(`${this.routePrefix}/fromToken`);
  }

  public updateSettings(settings: Settings) {
    return this.httpService.putFullRequest<Settings>(`${this.routePrefix}`, settings);
  }
}
