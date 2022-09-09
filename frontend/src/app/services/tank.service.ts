import { Injectable } from '@angular/core';
import { FuelTankInfoDTO } from 'src/models/DTO/FuelTank/fuel-tank-infoDTO';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class TankService {

  public routePrefix = '/api/tank';

  constructor(private httpService: HttpService) { }

  public GetTank(id: number) {
    return this.httpService.getFullRequest<FuelTankInfoDTO>(`${this.routePrefix}/${id}`);
  }

}
