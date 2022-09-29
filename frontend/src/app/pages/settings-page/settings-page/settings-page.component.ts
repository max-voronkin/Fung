import { Component, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { Settings } from 'src/models/Entities/settings';
import { User } from 'src/models/Entities/user';

@Component({
  selector: 'app-settings-page',
  templateUrl: './settings-page.component.html',
  styleUrls: ['./settings-page.component.sass']
})
export class SettingsPageComponent implements OnInit {

  public spinner = false;

  public currentUser!: User;
  public settings!: Settings;

  private unsubscribe$ = new Subject<void>();

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.getUser();
    this.getSettings();
  }

  public getUser(): void {
    this.dataService.getUser().pipe(
      takeUntil(this.unsubscribe$))
      .subscribe((user) => this.currentUser = user);
  }

  public getSettings(): void {
    this.dataService.getSettings().pipe(
      takeUntil(this.unsubscribe$))
      .subscribe((settings) => this.settings = settings);
  }

}
