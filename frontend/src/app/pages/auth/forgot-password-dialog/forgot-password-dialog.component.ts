import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { UserForgotPasswordDTO } from 'src/models/DTO/User/user-forgotPasswordDTO';
import { RegisterFormValidationConstants } from 'src/models/validation-settings/register-form-validation';

@Component({
  selector: 'app-forgot-password-dialog',
  templateUrl: './forgot-password-dialog.component.html',
  styleUrls: ['./forgot-password-dialog.component.sass']
})
export class ForgotPasswordDialogComponent implements OnInit {

  exitIcon = faXmark;
  unsubscribe$ = new Subject<void>();
  isSuccess = false;
  isFail = false;

  public forgotPasswordDTO: UserForgotPasswordDTO = {} as UserForgotPasswordDTO;
  public passForm: FormGroup = new FormGroup({});
  public emailControl: FormControl;
  
  constructor(private dialogRef: MatDialogRef<ForgotPasswordDialogComponent>, private authService: AuthService) { 
    this.emailControl = new FormControl(this.forgotPasswordDTO.email, [
      Validators.required,
      Validators.email,
      Validators.pattern(RegisterFormValidationConstants.emailRegex)
    ]);
  }

  ngOnInit(): void {
    this.passForm = new FormGroup({
      emailControl: this.emailControl
    });
  }

  get emailError() : string {
    const ctrl = this.emailControl;
    if (ctrl.errors?.['required'] && ( ctrl.touched))
    {
      return 'Email is required';
    }
    if (ctrl.errors?.['pattern']) {
      return 'Incorrect email format';
    }
    return '';
  }

  closeForm(): void {
    this.dialogRef.close();
  }

  submitForm(): void {
    this.emailControl.markAsDirty();
    if (this.passForm.valid)
    {
      let s = this.authService.requestResetPassword(this.emailControl.value)
        .pipe(takeUntil(this.unsubscribe$))
          .subscribe((resp) => {
            if (resp.body === true)
            {
              this.isSuccess = true;
            }
            else
            {
              this.isFail = true;
            }
          })
    }
  }

}
