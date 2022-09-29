import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Subject, takeUntil } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { SettingsService } from 'src/app/services/settings.service';
import { Settings } from 'src/models/Entities/settings';
import { HeightUnit } from 'src/models/enums/height-unit';

@Component({
  selector: 'height-units-dialog',
  templateUrl: './height-units-dialog.component.html',
  styleUrls: ['./height-units-dialog.component.sass']
})
export class HeightUnitsDialogComponent implements OnInit {

  constructor(
    @Inject(MAT_DIALOG_DATA) public settings: Settings, 
    private dialogRef: MatDialogRef<HeightUnitsDialogComponent>,
    private dataService: DataService,
    private settingsService: SettingsService) { }

  public selected: HeightUnit | undefined = this.settings.heightUnit;

  ngOnInit(): void {
  }

  onChange(value: number): void {
    this.selected = value;
    this.settings.heightUnit = this.selected;
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
