import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'fung-button',
  templateUrl: './fung-button.component.html',
  styleUrls: ['./fung-button.component.sass']
})
export class FungButtonComponent implements OnInit {

  @Input() public width = '100%';
  @Input() public height = '35px';
  constructor() { }

  ngOnInit(): void {
  }

}
