import { Component, Input, OnInit } from '@angular/core';
import { faArrowRotateRight } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { StationService } from 'src/app/services/station.service';
import { Station } from 'src/models/Entities/station';

@Component({
  selector: 'station-info',
  templateUrl: './station-info.component.html',
  styleUrls: ['./station-info.component.sass']
})
export class StationInfoComponent implements OnInit {

  @Input() public station: Station = {} as Station;
  refreshIcon = faArrowRotateRight;
  private unsubscribe$ = new Subject<void>();
  
  constructor(private stationService: StationService) { }

  ngOnInit(): void {
  }

  refreshStation() {
    this.stationService.GetStation(this.station.id).pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => this.station = resp.body!);
  }

}
