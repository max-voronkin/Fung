import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import { User } from 'src/models/Entities/user';
import { ChangePasswordDialogComponent } from '../change-password-dialog/change-password-dialog.component';

@Component({
  selector: 'user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.sass']
})
export class UserSettingsComponent implements OnInit {

  @Input() public user!: User;

  caretRightIcon = faCaretRight;

  constructor(private changePassDialog: MatDialog) { }

  ngOnInit(): void {
  }

  onChangePasswordClick(): void {
    this.changePassDialog.open(ChangePasswordDialogComponent, {
      data: this.user.id,
      panelClass: 'mat-dialog'
    });
  }

}
