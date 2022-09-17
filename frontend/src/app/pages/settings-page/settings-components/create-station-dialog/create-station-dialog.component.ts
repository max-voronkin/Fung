import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { CreateStationValidationConstants } from 'src/models/validation-settings/create-station-validation';

@Component({
  selector: 'create-station-dialog',
  templateUrl: './create-station-dialog.component.html',
  styleUrls: ['./create-station-dialog.component.sass']
})
export class CreateStationDialogComponent implements OnInit {

  exitIcon = faXmark;

  public stationName: string = '';
  public stationForm: FormGroup = new FormGroup({});
  public stationNameControl: FormControl;

  constructor(@Inject(MAT_DIALOG_DATA) public userId: number) {
    this.stationNameControl = new FormControl(this.stationName, [
      Validators.required,
      Validators.minLength(CreateStationValidationConstants.minNameLength),
    ]);
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
      alert('submit'); 
    }
  }

  closeForm(): void {

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
