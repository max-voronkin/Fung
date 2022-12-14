import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-auth-page',
  templateUrl: './auth-page.component.html',
  styleUrls: ['./auth-page.component.sass']
})
export class AuthPageComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    if(!this.route.snapshot.firstChild)
    {
      this.router.navigate(['login'], {relativeTo: this.route, replaceUrl: true});
    }
  }

}
