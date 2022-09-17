import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faCaretRight, faPlus } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { StationService } from 'src/app/services/station.service';
import { Station } from 'src/models/Entities/station';
import { CreateStationDialogComponent } from '../create-station-dialog/create-station-dialog.component';

@Component({
  selector: 'stations-settings',
  templateUrl: './stations-settings.component.html',
  styleUrls: ['./stations-settings.component.sass']
})
export class StationsSettingsComponent implements OnInit {

  caretRightIcon = faCaretRight;
  plusIcon = faPlus;
  private unsubscribe$ = new Subject<void>();

  public stations!: Array<Station>;

  constructor(private stationService: StationService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.stationService.GetStations().pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => {
        this.stations = resp.body!;
      })
  }

  onCreateStationClick(): void {
    this.dialog.open(CreateStationDialogComponent, {
      data: 1,
      panelClass: 'mat-dialog'
    });
  }

  onStationClick(station: Station): void {
    alert('In development');
  }

}
