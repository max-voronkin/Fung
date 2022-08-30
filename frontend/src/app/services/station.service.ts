import { Injectable } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { Station } from 'src/models/Entities/station';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class StationService {
  public routePrefix = '/api/station';

  constructor(private httpService: HttpService) { }

  public GetStations() {
    return this.httpService.getFullRequest<Array<Station>>(`${this.routePrefix}`);
  }
}
