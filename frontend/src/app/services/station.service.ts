import { Injectable } from '@angular/core';
import { StationCreateDTO } from 'src/models/DTO/Station/station-createDTO';
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

  public GetStation(id: number) {
    return this.httpService.getFullRequest<Station>(`${this.routePrefix}/${id}`);
  }

  public CreateStation(stationDTO: StationCreateDTO) {
    return this.httpService.postFullRequest<Station>(`${this.routePrefix}`, stationDTO);
  }
}
