import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { faBook, faChartLine, faFlask, faL, faRulerVertical, faTemperatureFull } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { TankService } from 'src/app/services/tank.service';
import { FuelTankInfoDTO } from 'src/models/DTO/FuelTank/fuel-tank-infoDTO';

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

  public get volumeInPercentage(): number {
    return Math.round(this.tank.currentAmount / (this.tank.capacity / 100));
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

    this.spinner = !this.spinner;
    this.tankService.GetTank(this.tankId)
      .pipe(takeUntil(this.unsubscribe$))
        .subscribe((resp) => {
          this.tank = resp.body!
          this.spinner = !this.spinner;
          this.bookTransactions = true;
        });
  }

  bookButtonClick() {
    this.levelTransactions = false;
    this.bookTransactions = true;
    this.graphRepresentation = false;
  }

  rulerButtonClick() {
    this.levelTransactions = true;
    this.bookTransactions = false;
    this.graphRepresentation = false;
  }

  graphButtonClick() {
    this.levelTransactions = false;
    this.bookTransactions = false;
    this.graphRepresentation = true;
  }

  toggleUnits()
  {
    this.displayValueInPercentage = !this.displayValueInPercentage;
  }

}
