import { Component, Input, OnInit } from '@angular/core';
import { RemainingTransaction } from 'src/models/Entities/remaining-transaction';

@Component({
  selector: 'book-transactions-table',
  templateUrl: './book-transactions-table.component.html',
  styleUrls: ['./book-transactions-table.component.sass']
})
export class BookTransactionsTableComponent implements OnInit {

  @Input() public transactions?: Array<RemainingTransaction>;
  
  public get minutesFromLastTransaction(): number { 
    return this.transactions != null ? Math.round((new Date().getTime() - new Date(this.transactions![0].transactionTime).getTime()) / 60000) : 0;
  }
  
  constructor() { }

  ngOnInit(): void {

  }

}
