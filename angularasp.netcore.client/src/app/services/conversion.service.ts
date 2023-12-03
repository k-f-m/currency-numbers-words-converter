import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConversionService {
  // API endpoint URL
  private apiUrl = 'https://localhost:7073/api/Conversion';

  constructor(private http: HttpClient) { }

  convert(value: string) {
    console.log(value);
    return this.http.post(this.apiUrl, { value }, { responseType: 'text' });
  }
}
