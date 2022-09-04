import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { TankService } from 'src/app/services/tank.service';
import { FuelTankInfoDTO } from 'src/models/DTO/FuelTank/fuel-tank-infoDTO';
import { FuelTank } from 'src/models/Entities/fuel-tank';

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
        });
  }

}
