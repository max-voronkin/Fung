import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthRoutes } from './components/auth/auth.routes';
import { MainPageRoutes } from './components/main-page/main-page.routes';

const routes: Routes = [
  ...AuthRoutes,
  ...MainPageRoutes,
  {path: '**', redirectTo: 'auth'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
