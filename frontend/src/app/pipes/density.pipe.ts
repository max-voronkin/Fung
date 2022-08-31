import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'density'
})
export class DensityPipe implements PipeTransform {

  transform(value: number): number {
    return Math.round(value * 10) / 10;
  }

}
