import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { faEnvelope, faKey, faUser, faUserPlus } from '@fortawesome/free-solid-svg-icons';
import { Subject, takeUntil } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { EventService } from 'src/app/services/event.service';
import { UserService } from 'src/app/services/user.service';
import { UserLoginDTO } from 'src/models/DTO/User/user-loginDTO';
import { RegisterFormValidationConstants } from 'src/models/validation-settings/register-form-validation';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.sass']
})
export class LoginPageComponent implements OnInit {

  private unsubscribe$ = new Subject<void>();
  
  userPlus = faUserPlus;
  user = faUser;
  email = faEnvelope;
  password = faKey;

  public loginUser: UserLoginDTO = {}; 
  public loginForm: FormGroup = new FormGroup({});
  public emailControl: FormControl;
  public passwordControl: FormControl;

  constructor(private router: Router, private route: ActivatedRoute, private authService: AuthService, private eventService: EventService) {
    
    this.emailControl = new FormControl(this.loginUser.email, [
      Validators.required,
      Validators.email,
      Validators.pattern(RegisterFormValidationConstants.emailRegex)
    ]);

    this.passwordControl = new FormControl(this.loginUser.password, [
      Validators.required,
      Validators.minLength(RegisterFormValidationConstants.passwordMinLength),
    ]);

   }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      emailControl: this.emailControl,
      passwordControl: this.passwordControl
    });
  }

  redirectToRegister() : void {
    this.router.navigate(['../register'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  submitForm() : void {
    this.loginForm.markAllAsTouched();
    if (this.loginForm.valid)
    {
      this.loginUser.email = this.emailControl.value;
      this.loginUser.password = this.passwordControl.value;
      this.authService.login(this.loginUser)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((response) => 
      {
        if (response)
        {
           this.eventService.userLoggedIn();
        }
      });
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

}
