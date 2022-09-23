import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { faCircleInfo, faFlask, faRulerVertical, faTemperature0, faTemperatureFull } from '@fortawesome/free-solid-svg-icons';
import { map, Subscription, timer } from 'rxjs';
import { FuelTank } from 'src/models/Entities/fuel-tank';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from 'src/environments/environment';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

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
  minutesFromUpdate: number | undefined;

  public get progress(): number {
    return this.tank.levelTransactions![0] != null ? Math.round((this.tank.levelTransactions![0].volume / (this.tank.capacity / 100)) * 100) / 100 : 0;
  }

  public get h(): number {
    return this.tank.levelTransactions![0] != null ? this.tank.levelTransactions![0].height : 0;
  }

  public get d(): number {
    return this.tank.levelTransactions![0] != null ? this.tank.levelTransactions![0].density : 0;
  }

  public get t(): number {
    return this.tank.levelTransactions![0] != null ? this.tank.levelTransactions![0].temperature : 0;
  }

  public get currentAmount(): number {
    return this.tank.levelTransactions![0] != null ? this.tank.levelTransactions![0].volume : 0;
  }
  
  timerSubscription?: Subscription; 

  private hubConnection!: HubConnection;

  constructor(private router: Router, private route: ActivatedRoute,) {
    this.registerHub();
   }

  ngOnInit(): void {
    this.timerSubscription = timer(0, 60000).pipe( 
      map(() => { 
        this.updateTime();
      }) 
    ).subscribe(); 
  }

  ngOnDestroy(): void { 
    this.timerSubscription?.unsubscribe(); 
    this.hubConnection.stop();
  } 

  redirectToTankInfo(): void {
    this.router.navigate(['../tank/'+ this.tank.id], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  updateTime(): void {
    if (this.tank.levelTransactions![0])
    {
      this.minutesFromUpdate = Math.round((new Date().getTime() - new Date(this.tank.levelTransactions![0].transactionTime).getTime()) / 60000);
    }   
  }

  public registerHub(): void {
    this.hubConnection = new HubConnectionBuilder().withUrl(`${environment.apiUrl}/communication/levelTransaction`).build();
    this.hubConnection.start()
      .then(() =>  this.hubConnection.invoke('SetConnectionAsync', this.tank.id))
      .catch((err) => {
      console.log(err);     
    });

    this.hubConnection.on('NewTransaction', (newTransaction: LevelTransaction) => {
      if (newTransaction)
      {
        this.tank.levelTransactions![0] = newTransaction;
        this.updateTime();
      }
    });    

  }

}
