import { Pipe, PipeTransform } from '@angular/core';
import { VolumeUnit } from 'src/models/enums/volume-unit';
import { DataService } from '../services/data.service';

@Pipe({
  name: 'volume'
})
export class VolumePipe implements PipeTransform {
  constructor (private dataService: DataService) {}

  transform(value: number): number {
    switch (this.dataService.volumeUnits!) {
      case VolumeUnit.CubicMetre: {
        return Math.round(value * 100) / 100;
      }
      case VolumeUnit.Liter: {
        return Math.round((value * 1000) * 10) / 10;
      }
    }  
  }

}
