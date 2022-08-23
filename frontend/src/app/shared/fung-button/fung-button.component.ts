import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IconDefinition } from '@fortawesome/fontawesome-svg-core';

@Component({
  selector: 'fung-button',
  templateUrl: './fung-button.component.html',
  styleUrls: ['./fung-button.component.sass']
})
export class FungButtonComponent implements OnInit {

  @Input() public width = '100%';
  @Input() public height = '55px';
  @Input() public label = 'Button';
  @Input() public icon?: IconDefinition = undefined;
  @Input() public class = '';

  @Output() onButtonClick = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }
  onClick(): void {
    this.onButtonClick.emit();
  }

}
