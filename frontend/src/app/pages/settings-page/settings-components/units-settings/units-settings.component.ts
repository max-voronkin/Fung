import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import { Settings } from 'src/models/Entities/settings';
import { HeightUnitsDialogComponent } from '../height-units-dialog/height-units-dialog.component';
import { VolumeUnitsDialogComponent } from '../volume-units-dialog/volume-units-dialog.component';

@Component({
  selector: 'units-settings',
  templateUrl: './units-settings.component.html',
  styleUrls: ['./units-settings.component.sass']
})
export class UnitsSettingsComponent implements OnInit {

  caretRightIcon = faCaretRight;

  @Input() public settings!: Settings;
  
  constructor(private dialogHeight: MatDialog, private dialogVolume: MatDialog) { }

  ngOnInit(): void {
  }

  onHeightUnitsClick(): void {
    let dialogRef = this.dialogHeight.open(HeightUnitsDialogComponent, {
      data: this.settings,
      panelClass: 'mat-dialog'
    });

    dialogRef.afterClosed().subscribe((res) => {
      if (res != undefined)
      {
        console.log(res);
      }
    });

  }
  
  onVolumeUnitsClick(): void {
    let dialogRef = this.dialogVolume.open(VolumeUnitsDialogComponent, {
      data: this.settings,
      panelClass: 'mat-dialog'
    });

    dialogRef.afterClosed().subscribe((res) => {
      if (res != undefined)
      {
        console.log(res);
      }
    });

  }

}
