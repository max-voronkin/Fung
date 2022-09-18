import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Station } from 'src/models/Entities/station';
import {Clipboard} from '@angular/cdk/clipboard';
import { ErrorNotificationService } from 'src/app/services/error-notification.service';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { StationService } from 'src/app/services/station.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'station-info-dialog',
  templateUrl: './station-info-dialog.component.html',
  styleUrls: ['./station-info-dialog.component.sass']
})
export class StationInfoDialogComponent implements OnInit {

  exitIcon = faXmark;
  unsubscribe$ = new Subject<void>();

  constructor(
    @Inject(MAT_DIALOG_DATA) public station: Station, 
    private dialogRef: MatDialogRef<StationInfoDialogComponent>, 
    private clipboard: Clipboard,
    private notificationService: ErrorNotificationService,
    private stationService: StationService) { }

  ngOnInit(): void {
  }

  copyToClipboard(): void {
    this.clipboard.copy(this.station.token);
    this.notificationService.showInfoMessage('Copied!');
  }

  deleteStation(): void {
    this.stationService.DeleteStation(this.station.id).pipe(takeUntil(this.unsubscribe$))
      .subscribe((resp) => {
        this.dialogRef.close({stationId: this.station.id, result: resp});
      })
  }

  closeForm(): void {
    this.dialogRef.close();
  }

}
