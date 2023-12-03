import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TranslationService {
  private apiUrl = 'https://localhost:7073/api/Translation'; // Replace with your API endpoint

  constructor(private http: HttpClient) { }

  translate(value: string) {
    return this.http.post(this.apiUrl, { value });
  }
}
