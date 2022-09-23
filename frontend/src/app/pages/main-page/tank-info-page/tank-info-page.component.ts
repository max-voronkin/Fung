import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { faBook, faChartLine, faFlask, faL, faRulerVertical, faTemperatureFull } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { TankService } from 'src/app/services/tank.service';
import { environment } from 'src/environments/environment';
import { FuelTankInfoDTO } from 'src/models/DTO/FuelTank/fuel-tank-infoDTO';
import { LevelTransaction } from 'src/models/Entities/level-transaction';

@Component({
  selector: 'app-tank-info-page',
  templateUrl: './tank-info-page.component.html',
  styleUrls: ['./tank-info-page.component.sass']
})
export class TankInfoPageComponent implements OnInit {

  tankId!: number;
  spinner = false;
  private unsubscribe$ = new Subject<void>();

  public tank: FuelTankInfoDTO = {} as FuelTankInfoDTO;

  levelTransactions : boolean = false;
  bookTransactions : boolean = false;
  graphRepresentation : boolean = false;
  displayValueInPercentage = true;

  bookIcon = faBook;
  rulerIcon = faRulerVertical;
  graphIcon = faChartLine;
  flaskIcon = faFlask;
  temperatureIcon = faTemperatureFull;

  private hubConnection!: HubConnection;

  public newTransactionSubject :Subject<LevelTransaction> = new Subject<LevelTransaction>();

  public get volumeInPercentage(): number {
    if (this.tank.levelTransactions == undefined)
    return 0;
    return this.tank.levelTransactions[0] != null ? Math.round((this.currentVolume / (this.tank.capacity / 100)) * 100) / 100 : 0;
  }

  public get currentVolume(): number {
    return this.tank.levelTransactions![0] != null ? this.tank.levelTransactions![0].volume : 0;
  }

  public get gradientStyle() {
    return {'background-image': `linear-gradient(to top, #8AAAE5 0% ${this.volumeInPercentage}%, #ebebeb 0% ${100 - this.volumeInPercentage}%)`}
  }

  public get h(): number {
    return this.tank.levelTransactions![0] ? this.tank.levelTransactions![0].height : 0;
  }
  public get d(): number {
    return this.tank.levelTransactions![0] ? this.tank.levelTransactions![0].density : 0;
  }
  public get t(): number {
    return this.tank.levelTransactions![0] ? this.tank.levelTransactions![0].temperature : 0;
  }

  constructor(private route: ActivatedRoute, private tankService: TankService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.tankId = params.get('id') as unknown as number;
    });

    this.getTankInfo();
    this.bookTransactions = true;
    this.registerHub();
  }

  public getTankInfo(): void {
    this.spinner = !this.spinner;
    this.tankService.GetTank(this.tankId)
      .pipe(takeUntil(this.unsubscribe$))
        .subscribe((resp) => {
          this.tank = resp.body!
          this.spinner = !this.spinner;   
        });
  }

  bookButtonClick(): void {
    this.levelTransactions = false;
    this.bookTransactions = true;
    this.graphRepresentation = false;
  }

  rulerButtonClick(): void {
    this.levelTransactions = true;
    this.bookTransactions = false;
    this.graphRepresentation = false;
  }

  graphButtonClick(): void {
    this.levelTransactions = false;
    this.bookTransactions = false;
    this.graphRepresentation = true;
  }

  toggleUnits(): void {
    this.displayValueInPercentage = !this.displayValueInPercentage;
  }

  public registerHub(): void {
    this.hubConnection = new HubConnectionBuilder().withUrl(`${environment.apiUrl}/communication/levelTransaction`).build();
    this.hubConnection.start()
      .then(() => this.hubConnection.invoke('SetConnectionAsync', Number(this.tankId)))
      .catch((err) => {
      console.log(err);     
    });

    this.hubConnection.on('NewTransaction', (newTransaction: LevelTransaction) => {
      if (newTransaction)
      {
        this.tank.levelTransactions!.unshift(newTransaction);
        this.emitNewTransactionEvent(newTransaction);
      }
    });    
  }

  public emitNewTransactionEvent(transaction: LevelTransaction): void {
    this.newTransactionSubject.next(transaction);
  }

}
