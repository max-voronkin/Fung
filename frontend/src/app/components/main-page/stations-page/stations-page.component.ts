import { Component, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { StationService } from 'src/app/services/station.service';
import { Station } from 'src/models/Entities/station';
@Component({
  selector: 'app-stations-page',
  templateUrl: './stations-page.component.html',
  styleUrls: ['./stations-page.component.sass']
})
export class StationsPageComponent implements OnInit {

  spinner = false;
  private unsubscribe$ = new Subject<void>();
  stations: Array<Station> = [] as Array<Station>;

  constructor(private stationService: StationService) { }

  ngOnInit(): void {
    this.spinner = !this.spinner;
    this.stationService.GetStations()
      .pipe(takeUntil(this.unsubscribe$))
        .subscribe((resp) => {
          this.stations = resp.body!
          this.spinner = !this.spinner;
        });
  }

}
