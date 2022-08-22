import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'fung-logo',
  templateUrl: './fung-logo.component.html',
  styleUrls: ['./fung-logo.component.sass']
})
export class FungLogoComponent implements OnInit {
  @Input() public width = '100%';
  @Input() public height = '100%';
  @Input() public color = 'black';

  constructor() { }

  ngOnInit(): void {
  }

}
