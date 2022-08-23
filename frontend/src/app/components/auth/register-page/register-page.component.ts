import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { faEnvelope, faKey, faKeyboard, faUser, faUserPlus } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.sass']
})
export class RegisterPageComponent implements OnInit {

  userPlus = faUserPlus;
  user = faUser;
  email = faEnvelope;
  password = faKeyboard;
  confirm = faKey;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  redirectToLogin() : void {
    this.router.navigate(['auth/login']);
  }

}
