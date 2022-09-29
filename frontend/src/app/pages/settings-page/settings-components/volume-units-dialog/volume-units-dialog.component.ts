import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Subject, takeUntil } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { SettingsService } from 'src/app/services/settings.service';
import { Settings } from 'src/models/Entities/settings';
import { VolumeUnit } from 'src/models/enums/volume-unit';

@Component({
  selector: 'volume-units-dialog',
  templateUrl: './volume-units-dialog.component.html',
  styleUrls: ['./volume-units-dialog.component.sass']
})
export class VolumeUnitsDialogComponent implements OnInit {

  constructor(
    @Inject(MAT_DIALOG_DATA) public settings: Settings, 
    private dialogRef: MatDialogRef<VolumeUnitsDialogComponent>,
    private dataService: DataService,
    private settingsService: SettingsService) { }

    public selected: VolumeUnit | undefined = this.settings.volumeUnit;

  ngOnInit(): void {
  }

  onChange(value: number): void {
    this.selected = value;
    this.settings.volumeUnit = this.selected;
    this.updateSettings(this.settings);
    //this.dialogRef.close();
  }

  updateSettings(s: Settings): void {
    this.settingsService.updateSettings(s)
    .pipe(takeUntil(new Subject<void>))
    .subscribe((res) => {
      this.dataService.updateSettings(res.body!);
    })
  }

}
