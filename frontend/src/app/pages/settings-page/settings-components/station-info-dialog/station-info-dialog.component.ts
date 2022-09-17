import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Station } from 'src/models/Entities/station';
import {Clipboard} from '@angular/cdk/clipboard';
import { ErrorNotificationService } from 'src/app/services/error-notification.service';

@Component({
  selector: 'station-info-dialog',
  templateUrl: './station-info-dialog.component.html',
  styleUrls: ['./station-info-dialog.component.sass']
})
export class StationInfoDialogComponent implements OnInit {

  constructor(
    @Inject(MAT_DIALOG_DATA) public station: Station, 
    private dialogRef: MatDialogRef<StationInfoDialogComponent>, 
    private clipboard: Clipboard,
    private notificationService: ErrorNotificationService) { }

  ngOnInit(): void {
  }

  copyToClipboard(): void {
    this.clipboard.copy(this.station.token);
    this.notificationService.showInfoMessage('Copied!');
  }

}
