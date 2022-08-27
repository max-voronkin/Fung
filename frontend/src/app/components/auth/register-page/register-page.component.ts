import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { faEnvelope, faKey, faKeyboard, faUser, faUserPlus } from '@fortawesome/free-solid-svg-icons';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { EventService } from 'src/app/services/event.service';
import { UserRegisterDTO } from 'src/models/DTO/User/user-registerDTO';
import { RegisterFormValidationConstants } from 'src/models/validation-settings/register-form-validation';

@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.sass']
})
export class RegisterPageComponent implements OnInit, OnDestroy {

  private unsubscribe$ = new Subject<void>();
  
  userPlus = faUserPlus;
  user = faUser;
  email = faEnvelope;
  password = faKeyboard;
  confirm = faKey;

  public newUser: UserRegisterDTO = {}; 
  public registerForm: FormGroup = new FormGroup({});
  public emailControl: FormControl;
  public passwordControl: FormControl;
  public confirmPasswordControl: FormControl;

  public confirmPassword = '';

  constructor(private router: Router, private route: ActivatedRoute, private authService: AuthService, private eventService: EventService) {
    this.emailControl = new FormControl(this.newUser.email, [
      Validators.required,
      Validators.email,
      Validators.pattern(RegisterFormValidationConstants.emailRegex)
    ]);

    this.passwordControl = new FormControl(this.newUser.password, [
      Validators.required,
      Validators.minLength(RegisterFormValidationConstants.passwordMinLength),
    ]);

    this.confirmPasswordControl = new FormControl(this.confirmPassword, [
      Validators.required
    ]);

   }
  ngOnDestroy(): void {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
  }

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      emailControl: this.emailControl,
      passwordControl: this.passwordControl,
      confirmPasswordControl: this.confirmPasswordControl,
    });
  }

  redirectToLogin() : void {
    this.router.navigate(['../login'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  submitForm() : void {
    this.registerForm.markAllAsTouched();
    if (this.registerForm.valid)
    {
      this.newUser.email = this.emailControl.value;
      this.newUser.password = this.passwordControl.value;
      
      this.authService.register(this.newUser)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(() => this.eventService.userLoggedIn());
    }
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

  get passwordError() : string {
    const ctrl = this.passwordControl;
    if (ctrl.errors?.['required'] && (ctrl.dirty || ctrl.touched))
    {
      return 'Password is required';
    }
    if (ctrl.errors?.['minlength'])
    {
      return 'Password should be at least 8 characters';
    }
    return '';
  }

  get confirmPasswordError() : string {
    const ctrl = this.confirmPasswordControl;
    if (ctrl.value != this.passwordControl.value && (ctrl.dirty || ctrl.touched))
    {
      this.confirmPasswordControl.setErrors({invalid: true})
      return 'Should match with password';
    }
    return '';
  }
}
