import { Pipe, PipeTransform } from '@angular/core';

Pipe({
  name: 'customPipe'
})
export class CustomPipePipe implements PipeTransform{
  transform(basic:number,hra:number = 0.1*basic,ta:number = 0.05*basic , da:number = 0.03*basic):number{
    return basic + hra + ta +  da;
  }
}