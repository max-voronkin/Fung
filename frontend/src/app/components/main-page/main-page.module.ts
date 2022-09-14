import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
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
import { NgChartsModule } from 'ng2-charts';
import { LevelChartsComponent } from './components/level-charts/level-charts.component';
import { VolumePipe } from 'src/app/pipes/volume.pipe';
import { VolumeChartComponent } from './components/charts/volume-chart/volume-chart.component';
import { HeightChartComponent } from './components/charts/height-chart/height-chart.component';
import { DensityChartComponent } from './components/charts/density-chart/density-chart.component';
import { HeightPipe } from 'src/app/pipes/height.pipe';
import { DensityPipe } from 'src/app/pipes/density.pipe';



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
    LevelTransactionComponent,
    VolumeChartComponent,
    LevelChartsComponent,
    HeightChartComponent,
    DensityChartComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    NgChartsModule
  ],
  providers: [
    VolumePipe,
    DatePipe,
    HeightPipe,
    DensityPipe
  ]
})
export class MainPageModule { }
