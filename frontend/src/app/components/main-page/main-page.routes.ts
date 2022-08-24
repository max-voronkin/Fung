import { Routes } from '@angular/router';
import { MainPageOverlayComponent } from './main-page-overlay/main-page-overlay.component';
import { StationsPageComponent } from './stations-page/stations-page.component';

export const MainPageRoutes: Routes = [
  {
    path: 'main',
    component: MainPageOverlayComponent,
    children: [
      { path: 'stations', component: StationsPageComponent}
    ],
  },
];
