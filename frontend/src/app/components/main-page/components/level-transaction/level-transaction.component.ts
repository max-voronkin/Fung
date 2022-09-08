import { Component, Input, OnInit } from '@angular/core';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'level-transaction',
  templateUrl: './level-transaction.component.html',
  styleUrls: ['./level-transaction.component.sass']
})
export class LevelTransactionComponent implements OnInit {

  @Input() public transaction!: LevelTransaction;
  constructor() { }

  ngOnInit(): void {
  }

}
