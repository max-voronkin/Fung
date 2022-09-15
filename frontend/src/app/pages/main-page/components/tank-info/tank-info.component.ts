import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { faCircleInfo, faFlask, faRulerVertical, faTemperature0, faTemperatureFull } from '@fortawesome/free-solid-svg-icons';
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
  flaskIcon = faFlask;
  temperatureIcon = faTemperatureFull;
  progress: number | undefined;
  minutesFromUpdate: number | undefined;
  
  timerSubscription?: Subscription; 

  constructor(private router: Router, private route: ActivatedRoute,) { }

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
    this.router.navigate(['../tank/'+ this.tank.id], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  updateTime() {
    this.minutesFromUpdate = Math.round((new Date().getTime() - new Date(this.tank.levelTransactions![0].transactionTime).getTime()) / 60000);
  }

}