import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js';
import { Subject, takeUntil } from 'rxjs';
import { DensityPipe } from 'src/app/pipes/density.pipe';
import { LevelTransactionService } from 'src/app/services/level-transaction.service';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'density-chart',
  templateUrl: './density-chart.component.html',
  styleUrls: ['./density-chart.component.sass']
})
export class DensityChartComponent implements OnInit {

  public transactions: Array<LevelTransaction> = [];
  public tankId!: number;
  public hours!: number;
  public spinner: boolean = false;
  private unsubscribe$ = new Subject<void>();

  chart!: Chart;
  private labels: (string | null)[]= [];
  private densityData: number[] = [];
  
  constructor(private datePipe: DatePipe, private densityPipe: DensityPipe, private levelTransactionService: LevelTransactionService) { }

  ngOnDestroy(): void {
    this.chart.destroy();
  }

  ngOnInit(): void {
    this.chart = new Chart('density-canvas', {
      type: 'line',
      data: {
        labels: this.labels,
        datasets: [
          {
            label: 'Density',
            data: this.densityData,
            backgroundColor: 'red',
            borderColor: 'red',
            fill: false
          }
        ]        
      },
      options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
    })
  }

  updateChart(tankId: number, hours: number): void {
    this.spinner = !this.spinner;

    this.levelTransactionService.GetTransactionsByPeriod(tankId, hours)
    .pipe(takeUntil(this.unsubscribe$))
    .subscribe((resp) => {
      this.transactions = resp.body!
      this.spinner = !this.spinner;

      this.chart.data.labels = [];
      this.chart.data.labels?.push(...this.transactions.map(t => this.datePipe.transform(t.transactionTime, 'd/M/yy, h:mm')).reverse());
      this.chart.data.datasets[0].data = [];
      this.chart.data.datasets[0].data.push(...this.transactions.map(t => this.densityPipe.transform(t.density)).reverse());
      this.chart.update();
    })
  }

}
