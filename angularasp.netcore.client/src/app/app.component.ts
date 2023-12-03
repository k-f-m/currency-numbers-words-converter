import { Component } from '@angular/core';
import { TranslationService } from './services/translation.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
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
