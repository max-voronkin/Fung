import { DatePipe } from '@angular/common';
import { Component, Input, OnInit} from '@angular/core';
import { Chart } from 'chart.js';
import { VolumePipe } from 'src/app/pipes/volume.pipe';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'level-chart',
  templateUrl: './level-chart.component.html',
  styleUrls: ['./level-chart.component.sass']
})
export class LevelChartComponent implements OnInit{

  @Input() public transactions: Array<LevelTransaction> = [];
  @Input() public tankCapacity!: number;
  constructor(private volumePipe: VolumePipe, private datePipe: DatePipe) { }

  chart!: Chart;

  ngOnInit(): void {
    let labels = this.transactions.map(t => this.datePipe.transform(t.transactionTime, 'd/M/yy, h:mm'));
    let volumeData = this.transactions.map(t => this.volumePipe.transform(t.volume));
    let temperatureData = this.transactions.map(t => t.temperature);

    this.chart = new Chart('canvas', {
      type: 'line',
      data: {
        labels: labels,
        datasets: [
          {
            label: 'Volume',
            data: volumeData,
            backgroundColor: 'red',
            borderColor: 'red',
            fill: false
          }
        ]        
      },
      options: {
        scales: {
            y: {
                beginAtZero: true,
                max: this.volumePipe.transform(this.tankCapacity)
            }
        }
    }
    })
  }
}
