import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { faL, IconDefinition } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'fung-button-icon',
  templateUrl: './fung-button-icon.component.html',
  styleUrls: ['./fung-button-icon.component.sass']
})
export class FungButtonIconComponent implements OnInit {

  @Input() public icon?: IconDefinition = undefined;
  @Input() public isActive: boolean = false;
  @Input() public height: string = '50px';
  @Input() public width: string = '50px';

  constructor() { }

  ngOnInit(): void {
  }
 


}
