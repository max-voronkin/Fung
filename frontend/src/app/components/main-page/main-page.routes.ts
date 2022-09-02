import { Routes } from '@angular/router';
import { AuthGuard } from 'src/app/guards/auth.guard';
import { MainPageOverlayComponent } from './main-page-overlay/main-page-overlay.component';
import { StationsPageComponent } from './stations-page/stations-page.component';
import { TankInfoPageComponent } from './tank-info-page/tank-info-page.component';

export const MainPageRoutes: Routes = [
  {
    path: 'main',
    component: MainPageOverlayComponent,
    children: [
      { path: 'stations', component: StationsPageComponent, canActivate: [AuthGuard]},
      { path: 'tank/:id', component: TankInfoPageComponent, canActivate: [AuthGuard]}
    ],
  },
];
