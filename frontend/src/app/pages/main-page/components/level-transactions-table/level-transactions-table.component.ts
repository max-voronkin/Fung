import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'level-transactions-table',
  templateUrl: './level-transactions-table.component.html',
  styleUrls: ['./level-transactions-table.component.sass']
})
export class LevelTransactionsTableComponent implements OnInit {

  @Input() public transactions?: Array<LevelTransaction>;
  public minutesFromLastTransaction!: number;

  constructor() { }
  ngOnInit(): void {
    if (this.transactions!.length != 0)
    {
      this.minutesFromLastTransaction = Math.round((new Date().getTime() - new Date(this.transactions![0].transactionTime).getTime()) / 60000);
    }
  }

}
