import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/models/Entities/user';

@Component({
  selector: 'app-settings-page',
  templateUrl: './settings-page.component.html',
  styleUrls: ['./settings-page.component.sass']
})
export class SettingsPageComponent implements OnInit {

  public spinner = false;

  public currentUser!: User | null;

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.currentUser = this.userService.getUser();
  }

}
