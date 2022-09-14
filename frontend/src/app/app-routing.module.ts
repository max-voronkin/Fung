import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthRoutes } from './components/auth/auth.routes';
import { StationsPageComponent } from './components/main-page/stations-page/stations-page.component';
import { TankInfoPageComponent } from './components/main-page/tank-info-page/tank-info-page.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  ...AuthRoutes,
  {path: 'stations', component: StationsPageComponent, canActivate: [AuthGuard]},
  { path: 'tank/:id', component: TankInfoPageComponent, canActivate: [AuthGuard]},
  {path: '**', redirectTo: 'auth'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
