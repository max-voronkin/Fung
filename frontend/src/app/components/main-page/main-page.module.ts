import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StationsPageComponent } from './stations-page/stations-page.component';
import { MainPageOverlayComponent } from './main-page-overlay/main-page-overlay.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { TankInfoComponent } from './components/tank-info/tank-info.component';
import { StationInfoComponent } from './components/station-info/station-info.component';
import { TankInfoPageComponent } from './tank-info-page/tank-info-page.component';
import { BookTransactionsTableComponent } from './components/book-transactions-table/book-transactions-table.component';
import { LevelTransactionsTableComponent } from './components/level-transactions-table/level-transactions-table.component';
import { BookTransactionComponent } from './components/book-transaction/book-transaction.component';
import { LevelTransactionComponent } from './components/level-transaction/level-transaction.component';



@NgModule({
  declarations: [
    StationsPageComponent,
    MainPageOverlayComponent,
    TankInfoComponent,
    StationInfoComponent,
    TankInfoPageComponent,
    LevelTransactionsTableComponent,
    BookTransactionsTableComponent,
    BookTransactionComponent,
    LevelTransactionComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class MainPageModule { }
