import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private apiUrl = 'http://localhost:5101/api';

  constructor(private http: HttpClient) { }

  getItems(): Observable<any> {
    return this.http.get(`${this.apiUrl}/items`);
  }

  // Ejemplo de método POST
  createItem(data: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/items`, data);
  }
}