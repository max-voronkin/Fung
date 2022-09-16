import { Component, OnInit } from '@angular/core';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'units-settings',
  templateUrl: './units-settings.component.html',
  styleUrls: ['./units-settings.component.sass']
})
export class UnitsSettingsComponent implements OnInit {

  caretRightIcon = faCaretRight;
  
  constructor() { }

  ngOnInit(): void {
  }

  onHeightUnitsClick(): void {
    alert('In development')
  }
  
  onVolumeUnitsClick(): void {
    alert('In development')
  }

}
