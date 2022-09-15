import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { DropdownOption } from 'src/app/shared/fung-dropdown/fung-dropdown.component';
import { DensityChartComponent } from '../charts/density-chart/density-chart.component';
import { HeightChartComponent } from '../charts/height-chart/height-chart.component';
import { VolumeChartComponent } from '../charts/volume-chart/volume-chart.component';

@Component({
  selector: 'level-charts',
  templateUrl: './level-charts.component.html',
  styleUrls: ['./level-charts.component.sass']
})
export class LevelChartsComponent implements OnInit, AfterViewInit {

  @Input() public tankCapacity!: number;
  @Input() public tankId!: number;

  @ViewChild(VolumeChartComponent) volumeChart?: VolumeChartComponent;
  @ViewChild(HeightChartComponent) heightChart?: HeightChartComponent;
  @ViewChild(DensityChartComponent) densityChart?: DensityChartComponent;
  
  public typeOptions: Array<DropdownOption> = [
    {option: 'Volume', value: 0},
    {option: 'Height', value: 1},
    {option: 'Density', value: 2}
  ];

  public periodOptions: Array<DropdownOption> = [
    {option: '1 Hour', value: 1},
    {option: '12 Hours', value: 12},
    {option: '24 Hours', value: 24}
  ];
  
  public selectedType: DropdownOption | undefined;
  public selectedTime: DropdownOption | undefined;
  constructor() { }

  ngAfterViewInit(): void {
    setTimeout(() => {
      this.volumeChart?.updateChart(this.tankId, this.selectedTime!.value);
    }, 0)
  }

  ngOnInit(): void {
  }

  changeType(option: DropdownOption): void {
    this.selectedType = option;
    if (option.value === 0)
    {
      setTimeout(() => {
        this.volumeChart?.updateChart(this.tankId, this.selectedTime!.value);
      }, 0)     
    }
    else if (option.value === 1)
    {
      setTimeout(() => {
        this.heightChart?.updateChart(this.tankId, this.selectedTime!.value);
      }, 0)   
    }
    else 
    {
      setTimeout(() => {
        this.densityChart?.updateChart(this.tankId, this.selectedTime!.value);
      }, 0)   
    }
    
  }

  changeTime(option: DropdownOption): void {
    this.selectedTime = option;
    //this.volumeChart?.updateChart(this.tankId, this.selectedTime.value);
    if (this.selectedType!.value === 0)
    {
      this.volumeChart?.updateChart(this.tankId, this.selectedTime!.value);
    }
    else if (this.selectedType!.value === 1)
    {
      this.heightChart?.updateChart(this.tankId, this.selectedTime!.value);
    }
    else 
    {
      this.densityChart?.updateChart(this.tankId, this.selectedTime!.value);
    }
  }

}
