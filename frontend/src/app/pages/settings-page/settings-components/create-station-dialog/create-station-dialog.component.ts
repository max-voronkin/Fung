import { Component, Inject, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { StationService } from 'src/app/services/station.service';
import { StationCreateDTO } from 'src/models/DTO/Station/station-createDTO';
import { CreateStationValidationConstants } from 'src/models/validation-settings/create-station-validation';

@Component({
  selector: 'create-station-dialog',
  templateUrl: './create-station-dialog.component.html',
  styleUrls: ['./create-station-dialog.component.sass']
})
export class CreateStationDialogComponent implements OnInit {

  exitIcon = faXmark;
  unsubscribe$ = new Subject<void>();

  public newStation: StationCreateDTO = {} as StationCreateDTO;
  public stationForm: FormGroup = new FormGroup({});
  public stationNameControl: FormControl;

  constructor(@Inject(MAT_DIALOG_DATA) public userId: number, private dialogRef: MatDialogRef<CreateStationDialogComponent>, private stationService: StationService) {
    this.stationNameControl = new FormControl(this.newStation.name, [
      Validators.required,
      Validators.minLength(CreateStationValidationConstants.minNameLength),
    ]);
    this.newStation.userId = userId;
  }

  ngOnInit(): void {
    this.stationForm = new FormGroup({
      stationNameControl: this.stationNameControl
    });
  }

  submitForm() : void {
    this.stationForm.markAllAsTouched();
    if (this.stationForm.valid)
    {
      this.newStation.name = this.stationNameControl.value;
      this.stationService.CreateStation(this.newStation).pipe(takeUntil(this.unsubscribe$))
        .subscribe((resp) => {
          if (resp.body != null)
          {
            this.dialogRef.close(resp.body);
          }
        });    
    }
  }

  closeForm(): void {
    this.stationForm.reset();
    this.dialogRef.close();
  }

  get nameError() : string {
    const ctrl = this.stationNameControl;
    if (ctrl.errors?.['required'] && ( ctrl.touched))
    {
      return 'The name can`t be empty';
    }
    if (ctrl.errors?.['minlength']) {
      return 'Name should be at least 3 characters';
    }
    return '';
  }

}
