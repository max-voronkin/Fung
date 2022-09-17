import { Component, Input, OnInit } from '@angular/core';
import { IconDefinition } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'settings-menu-item',
  templateUrl: './settings-menu-item.component.html',
  styleUrls: ['./settings-menu-item.component.sass']
})
export class SettingsMenuItemComponent implements OnInit {

  @Input() public label: string = 'placeholder';
  @Input() public icon?: IconDefinition = undefined;

  constructor() { }

  ngOnInit(): void {
  }

}
