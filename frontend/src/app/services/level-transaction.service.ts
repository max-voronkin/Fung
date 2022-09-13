import { Injectable } from '@angular/core';
import { LevelTransaction } from 'src/models/Entities/level-transaction';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class LevelTransactionService {

  public routePrefix = '/api/leveltransaction';

  constructor(private httpService: HttpService) { }

  public GetTransactionsByPeriod(tankId: number, hours: number) {
    return this.httpService.getFullRequest<Array<LevelTransaction>>(`${this.routePrefix}/${tankId}/${hours}`);
  }
}
