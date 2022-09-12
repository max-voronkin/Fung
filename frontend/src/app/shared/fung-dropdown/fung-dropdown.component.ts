import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { faArrowAltCircleDown, faArrowAltCircleUp, faCaretDown, faCaretUp, faL } from '@fortawesome/free-solid-svg-icons';

export interface DropdownOption {
  option: string,
  value: number
}

@Component({
  selector: 'fung-dropdown',
  templateUrl: './fung-dropdown.component.html',
  styleUrls: ['./fung-dropdown.component.sass']
})

export class FungDropdownComponent implements OnInit {

  @Input() public height: string = '40px';
  @Input() public width: string = '100%';
  @Input() public minWidth: string = '100px';
  @Input() public label: string = '';
  @Input() public options: Array<DropdownOption> | undefined;

  public selectedOption: DropdownOption | undefined;
  @Output() onSelect = new EventEmitter<DropdownOption>();
  
  public expanded: boolean = false;
  dropdownIcon = faCaretDown;
  dropdownExpandedIcon = faCaretUp;

  constructor() {}

  ngOnInit(): void {
    if (this.options)
    {
      this.selectOption(this.options[0]);
    }
  }

  toggleDropdown(): void {
    this.expanded = !this.expanded;
  }

  selectOption(option: DropdownOption) : void {
    this.expanded = false;
    if (this.selectedOption != option)
    {
      this.selectedOption = option;
      this.onSelect.emit(option);
    }
  }

  clickedOutside(): void {
    this.expanded = false;
  }

}
