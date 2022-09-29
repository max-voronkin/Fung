import { Pipe, PipeTransform } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { Settings } from 'src/models/Entities/settings';
import { HeightUnit } from 'src/models/enums/height-unit';
import { DataService } from '../services/data.service';

@Pipe({
  name: 'height'
})
export class HeightPipe implements PipeTransform {

  constructor(private dataService: DataService) {}
  // public settings!: Settings;

  transform(value: number): number {
    // this.dataService.getSettings()
    //   .pipe(takeUntil(new Subject<void>))
    //   .subscribe(resp => this.settings = resp);

      
  switch (this.dataService.heightUnits!) {
    case HeightUnit.Meter: {
      return Math.round((value / 1000) * 1000) / 1000;
    }
    case HeightUnit.Centimeter: {
      return Math.round((value / 10) * 100) / 100;
    }
    case HeightUnit.Millimeter: {
      return Math.round(value * 100) / 100;
    }
  }
  }

}
