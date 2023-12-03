import { Component } from '@angular/core';
import { TranslationService } from '../services/translation.service';

@Component({
  selector: 'app-root',
  template: `
    <div *ngIf="translatedValue">
      Translated Value: {{ translatedValue }}
    </div>
  `
})
export class AppComponent {
  translatedValue?: string;

  constructor(private translationService: TranslationService) { }

  ngOnInit() {
    this.translationService.translate('Hello World!').subscribe((response: any) => {
      this.translatedValue = response;
    });
  }
}
