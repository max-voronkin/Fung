import { Component, Input, OnInit } from '@angular/core';
import { IconDefinition } from '@fortawesome/fontawesome-svg-core';

@Component({
  selector: 'fung-input',
  templateUrl: './fung-input.component.html',
  styleUrls: ['./fung-input.component.sass']
})
export class FungInputComponent implements OnInit {

  @Input() public type = 'text';
  @Input() public errorMessage = '';
  @Input() public width = '100%';
  @Input() public height = '40px';
  @Input() public placeholder = 'Enter some...'
  @Input() public icon?: IconDefinition = undefined;
  @Input() public iconPosition = 'right';
  @Input() public value = '';
  @Input() public marginTop = '';
  @Input() public label = '';

  constructor() { }

  ngOnInit(): void {
  }

}
