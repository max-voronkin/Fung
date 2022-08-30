import { Component, Input, OnInit } from '@angular/core';
import { faCircleInfo, faRulerVertical } from '@fortawesome/free-solid-svg-icons';
import { FuelTank } from 'src/models/Entities/fuel-tank';

@Component({
  selector: 'tank-info',
  templateUrl: './tank-info.component.html',
  styleUrls: ['./tank-info.component.sass']
})
export class TankInfoComponent implements OnInit {

  @Input() public width = 'auto';
  @Input() public height = 'auto';
  @Input() public tank: FuelTank = {} as FuelTank;
  infoIcon = faCircleInfo;
  rulerIcon = faRulerVertical;

  constructor() { }

  ngOnInit(): void {
  }

  redirectToTankInfo() {
    alert('Redirect to tank info page');
  }

}
