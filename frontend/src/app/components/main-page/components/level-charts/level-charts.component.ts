import { Component, Input, OnInit } from '@angular/core';
import { DropdownOption } from 'src/app/shared/fung-dropdown/fung-dropdown.component';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'level-charts',
  templateUrl: './level-charts.component.html',
  styleUrls: ['./level-charts.component.sass']
})
export class LevelChartsComponent implements OnInit {

  @Input() public transactions: Array<LevelTransaction> = [];
  @Input() public tankCapacity!: number;
  
  public typeOptions: Array<DropdownOption> = [
    {option: 'Volume', value: 0},
    {option: 'Level', value: 1},
    {option: 'Density', value: 2}
  ];

  public periodOptions: Array<DropdownOption> = [
    {option: 'Hour', value: 0},
    {option: '12 Hours', value: 1},
    {option: '24 Hours', value: 2}
  ];
  
  public selectedType: DropdownOption | undefined;
  public selectedTime: DropdownOption | undefined;
  constructor() { }

  ngOnInit(): void {
  }

  changeType(option: DropdownOption): void {
    this.selectedType = option;
  }

  changeTime(option: DropdownOption): void {
    this.selectedTime = option;
  }

}
