import { Component, Input, OnInit } from '@angular/core';
import { RemainingTransaction } from 'src/models/Entities/remaining-transaction';

@Component({
  selector: 'book-transactions-table',
  templateUrl: './book-transactions-table.component.html',
  styleUrls: ['./book-transactions-table.component.sass']
})
export class BookTransactionsTableComponent implements OnInit {

  @Input() public transactions?: Array<RemainingTransaction>;
  public minutesFromLastTransaction!: number;
  
  constructor() { }

  ngOnInit(): void {
    if (this.transactions!.length != 0)
    {
      this.minutesFromLastTransaction = Math.round((new Date().getTime() - new Date(this.transactions![0].transactionTime).getTime()) / 60000);
    }
    
  }

}
