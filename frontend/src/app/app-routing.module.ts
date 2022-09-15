import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthRoutes } from './pages/auth/auth.routes';
import { StationsPageComponent } from './pages/main-page/stations-page/stations-page.component';
import { TankInfoPageComponent } from './pages/main-page/tank-info-page/tank-info-page.component';
import { AuthGuard } from './guards/auth.guard';
import { SettingsPageComponent } from './pages/settings-page/settings-page.component';

const routes: Routes = [
  ...AuthRoutes,
  {path: 'stations', component: StationsPageComponent, canActivate: [AuthGuard]},
  {path: 'settings', component: SettingsPageComponent, canActivate: [AuthGuard]},
  {path: 'tank/:id', component: TankInfoPageComponent, canActivate: [AuthGuard]},
  {path: '**', redirectTo: 'auth/login'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
