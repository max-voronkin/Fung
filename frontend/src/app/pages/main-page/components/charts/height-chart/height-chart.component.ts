import { DatePipe } from '@angular/common';
import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Chart } from 'chart.js';
import { Observable, Subject, Subscription, takeUntil } from 'rxjs';
import { HeightPipe } from 'src/app/pipes/height.pipe';
import { LevelTransactionService } from 'src/app/services/level-transaction.service';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'height-chart',
  templateUrl: './height-chart.component.html',
  styleUrls: ['./height-chart.component.sass']
})
export class HeightChartComponent implements OnInit, OnDestroy {

  public transactions: Array<LevelTransaction> = [];
  public tankId!: number;
  public hours!: number;
  public spinner: boolean = false;
  private unsubscribe$ = new Subject<void>();

  chart!: Chart;
  private labels: (string | null)[]= [];
  private heightData: number[] = [];

  @Input() public newTransactionEvent!: Observable<LevelTransaction>;
  private newTransactionSubscription!: Subscription;
  
  constructor(private datePipe: DatePipe, private heightPipe: HeightPipe, private levelTransactionService: LevelTransactionService) { }

  ngOnDestroy(): void {
    this.chart.destroy();
    this.newTransactionSubscription.unsubscribe();
  }

  ngOnInit(): void {
    this.chart = new Chart('hight-canvas', {
      type: 'line',
      data: {
        labels: this.labels,
        datasets: [
          {
            label: 'Height',
            data: this.heightData,
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

    this.newTransactionSubscription = this.newTransactionEvent.subscribe((transaction) => this.pushToChart(transaction))
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
      this.chart.data.datasets[0].data.push(...this.transactions.map(t => this.heightPipe.transform(t.height)).reverse());
      this.chart.update();
    })
  }

  pushToChart(t: LevelTransaction): void {
    this.chart.data.labels?.push(this.datePipe.transform(t.transactionTime, 'd/M/yy, h:mm'));
    this.chart.data.datasets[0].data.push(this.heightPipe.transform(t.height));
    this.chart.update();
  }

}
