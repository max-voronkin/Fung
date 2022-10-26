import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { ErrorNotificationService } from 'src/app/services/error-notification.service';
import { UserService } from 'src/app/services/user.service';
import { UserChangePasswordDTO } from 'src/models/DTO/User/user-changePasswordDTO';
import { RegisterFormValidationConstants } from 'src/models/validation-settings/register-form-validation';

@Component({
  selector: 'change-password-dialog',
  templateUrl: './change-password-dialog.component.html',
  styleUrls: ['./change-password-dialog.component.sass']
})
export class ChangePasswordDialogComponent implements OnInit {

  exitIcon = faXmark;
  unsubscribe$ = new Subject<void>();

  public passForm: FormGroup = new FormGroup({});
  public oldPassControl: FormControl;
  public newPassControl: FormControl;
  public confirmPassControl: FormControl;
  public confirmPassword = '';

  public changePasswordDTO: UserChangePasswordDTO = {} as UserChangePasswordDTO;
  
  constructor(private dialogRef: MatDialogRef<ChangePasswordDialogComponent>, private userService: UserService, private notificationService: ErrorNotificationService) {
    this.oldPassControl = new FormControl(this.changePasswordDTO.password, [
      Validators.required
    ]);
    this.newPassControl = new FormControl(this.changePasswordDTO.newPassword, [
      Validators.required,
      Validators.minLength(RegisterFormValidationConstants.passwordMinLength)
    ]);
    this.confirmPassControl = new FormControl(this.confirmPassword, [
      Validators.required
    ]);
   }

   get oldPassError() : string {
    const ctrl = this.oldPassControl;
    if (ctrl.errors?.['required'] && ( ctrl.dirty))
    {
      return 'Can`t be empty';
    }
    return '';
  }

  get newPassError() : string {
    const ctrl = this.newPassControl;
    if (ctrl.errors?.['required'] && ( ctrl.dirty))
    {
      return 'Can`t be empty';
    }
    if (ctrl.errors?.['minlength']) {
      return 'Should be at least 8 characters';
    }
    return '';
  }

  get confirmPassError() : string {
    const ctrl = this.confirmPassControl;
    if (ctrl.value != this.newPassControl.value && (ctrl.dirty))
    {
      this.confirmPassControl.setErrors({invalid: true})
      return 'Should match with password';
    }
    return '';
  }

  ngOnInit(): void {
    this.passForm = new FormGroup({
      oldPassControl: this.oldPassControl,
      newPassControl: this.newPassControl,
      confirmPassControl: this.confirmPassControl
    });
  }

  closeForm(): void {
    this.dialogRef.close();
  }

  submitForm(): void {
    this.markAllControlsAsDirty();
    if (this.passForm.valid)
    {
      this.changePasswordDTO.password = this.oldPassControl.value;
      this.changePasswordDTO.newPassword =  this.newPassControl.value;
      this.userService.updatePassword(this.changePasswordDTO)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(resp => {
            this.notificationService.showInfoMessage('Your password has changed!');
            this.dialogRef.close();
        });
    }
  }

  markAllControlsAsDirty(): void {
    this.oldPassControl.markAsDirty();
    this.newPassControl.markAsDirty();
    this.confirmPassControl.markAsDirty();
  }

}
