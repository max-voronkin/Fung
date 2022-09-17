import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faCaretRight, faPlus } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { StationService } from 'src/app/services/station.service';
import { Station } from 'src/models/Entities/station';
import { User } from 'src/models/Entities/user';
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

  @Input() public user!: User | null;
  public stations!: Array<Station>;

  constructor(private stationService: StationService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.stationService.GetStations().pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => {
        this.stations = resp.body!;
      })
  }

  onCreateStationClick(): void {
    let dialogRef = this.dialog.open(CreateStationDialogComponent, {
      data: this.user?.id,
      panelClass: 'mat-dialog'
    });

    dialogRef.afterClosed().subscribe((res) => {
      if (res != undefined)
      {
        this.addStationToList(res);
      }
    });
  }

  onStationClick(station: Station): void {
    alert('In development');
  }

  addStationToList(station: Station): void {
    this.stations.push(station);
  }

}
