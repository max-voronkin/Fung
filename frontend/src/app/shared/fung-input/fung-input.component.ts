import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'fung-input',
  templateUrl: './fung-input.component.html',
  styleUrls: ['./fung-input.component.sass']
})
export class FungInputComponent implements OnInit {

  @Input() public type = 'text';
  @Input() public errorMessage = '';
  @Input() public width = '250px';
  @Input() public height = '40px';
  @Input() public placeholder = 'Enter some...'

  constructor() { }

  ngOnInit(): void {
  }

}
