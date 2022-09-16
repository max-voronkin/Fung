import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/models/Entities/user';

@Component({
  selector: 'user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.sass']
})
export class UserSettingsComponent implements OnInit {

  public user!: User | null;

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.user = this.userService.getUser();
  }

}
