import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { faCircleInfo, faRulerVertical } from '@fortawesome/free-solid-svg-icons';
import { map, Subscription, timer } from 'rxjs';
import { FuelTank } from 'src/models/Entities/fuel-tank';

@Component({
  selector: 'tank-info',
  templateUrl: './tank-info.component.html',
  styleUrls: ['./tank-info.component.sass']
})
export class TankInfoComponent implements OnInit, OnDestroy {

  @Input() public width = 'auto';
  @Input() public height = 'auto';
  @Input() public tank: FuelTank = {} as FuelTank;
  infoIcon = faCircleInfo;
  rulerIcon = faRulerVertical;
  progress: number | undefined;
  minutesFromUpdate: number | undefined;
  
  timerSubscription?: Subscription; 

  constructor() { }

  ngOnInit(): void {
    this.timerSubscription = timer(0, 60000).pipe( 
      map(() => { 
        this.updateTime();
      }) 
    ).subscribe(); 
    
    this.progress = this.tank.currentAmount / (this.tank.capacity / 100)
  }

  ngOnDestroy(): void { 
    this.timerSubscription?.unsubscribe(); 
  } 

  redirectToTankInfo() {
    alert('Redirect to tank info page');
  }

  updateTime() {
    this.minutesFromUpdate = Math.round((new Date().getTime() - new Date(this.tank.levelTransactions![0].transactionTime).getTime()) / 60000);
  }

}
