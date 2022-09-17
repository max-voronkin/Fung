import { Component, Input, OnInit } from '@angular/core';
import { RemainingTransaction } from 'src/models/Entities/remaining-transaction';

@Component({
  selector: 'book-transaction',
  templateUrl: './book-transaction.component.html',
  styleUrls: ['./book-transaction.component.sass']
})
export class BookTransactionComponent implements OnInit {

  @Input() transaction!: RemainingTransaction;

  constructor() { }

  ngOnInit(): void {
  }

}
