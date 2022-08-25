import { Component, Input, OnInit } from '@angular/core';
import { faArrowRightFromBracket, faBars, faEllipsisVertical, faGears, faHouse, faL } from '@fortawesome/free-solid-svg-icons';

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
  
  constructor() { }

  ngOnInit(): void {
  }

  toggleExpanded() {
    this.expanded = !this.expanded;
  }

}
