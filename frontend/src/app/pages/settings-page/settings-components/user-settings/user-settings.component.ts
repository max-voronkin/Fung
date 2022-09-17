import { Component, Input, OnInit } from '@angular/core';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import { User } from 'src/models/Entities/user';

@Component({
  selector: 'user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.sass']
})
export class UserSettingsComponent implements OnInit {

  @Input() public user!: User | null;

  caretRightIcon = faCaretRight;

  constructor() { }

  ngOnInit(): void {
  }

  onChangePasswordClick(): void {
    alert('In development');
  }

}
