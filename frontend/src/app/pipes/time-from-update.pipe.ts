import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'timeFromUpdate'
})
export class TimeFromUpdatePipe implements PipeTransform {

  transform(value: number): string {
    if (value > 60 && value < 1440)
    {
      //hours
      return `${Math.round((value / 60) * 10) / 10} hours ago`;     
    }
    else if (value > 1440)
    {
      //days
      return `${Math.round((value / 1440) * 10) / 10} days ago`;
    }
    return `${value} minutes ago`;
  }

}
