import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'volume'
})
export class VolumePipe implements PipeTransform {

  transform(value: number): number {
    return Math.round(value * 10) / 10;
  }

}
