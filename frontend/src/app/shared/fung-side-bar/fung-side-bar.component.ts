import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { faArrowRightFromBracket, faBars, faEllipsisVertical, faGears, faHouse, faL } from '@fortawesome/free-solid-svg-icons';
import { AuthService } from 'src/app/services/auth.service';
import { EventService } from 'src/app/services/event.service';

@Component({
  selector: 'fung-side-bar',
  templateUrl: './fung-side-bar.component.html',
  styleUrls: ['./fung-side-bar.component.sass']
})
export class FungSideBarComponent implements OnInit {

  @Input() public expanded = false;

  homeIcon = faHouse;
  logoutIcon = faArrowRightFromBracket;
  hamburgerMenuIcon = faBars;
  dotsIcon = faEllipsisVertical;
  gearsIcon = faGears;
  
  constructor(private authService: AuthService, private eventService: EventService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  toggleExpanded(): void {
    this.expanded = !this.expanded;
  }

  onLogoutClick(): void {
    this.authService.logout();
    this.eventService.userLoggedOut();
  }

  onSettingsClick(): void {
    this.router.navigate(['/settings'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

  onHomeClick(): void {
    this.router.navigate(['/stations'], {
      replaceUrl: true,
      relativeTo: this.route
    });
  }

}
