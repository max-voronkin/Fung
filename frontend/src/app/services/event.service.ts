import { Injectable } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor(private router: Router, private route: ActivatedRoute) { }

  public userLoggedIn()
  {
    this.router.navigate(['/stations'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  public userLoggedOut()
  {
    this.router.navigate(['/auth/login'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }
}
