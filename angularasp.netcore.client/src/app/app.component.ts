import { Component } from '@angular/core';
import { ConversionService } from './services/conversion.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  convertedValue?: string;

  constructor(private conversionService: ConversionService) { }

  onSubmit(num: NgForm) {
    console.log(num.value);
    this.conversionService.convert(num.value).subscribe((response: any) => {
      this.convertedValue = response;
    });
    console.log(num.value);
  }
}
