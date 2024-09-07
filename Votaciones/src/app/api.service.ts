import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Acta } from './actas/actas.component';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = 'https://localhost:7291/api';

  constructor(private http: HttpClient) { }

  getItems(): Observable<any> {
    return this.http.get(`${this.apiUrl}/Jrv`);
  }

  createItem(data: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/Jrv`, data);
  }

  getActaById(id: any): Observable<Acta> {
    return this.http.get<Acta>(`${this.apiUrl}/Jrv/${id}`);
  }

  updateItem(id: any, acta: Acta): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/Jrv/${id}`, acta);
  }

  deleteItem(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/Jrv/${id}`);
  }

  getNovedadesActas():Observable<any> {
    return this.http.get(`${this.apiUrl}/JrvNovedades`);
  }
  createNovedadesActas(data: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/JrvNovedades`, data);
  }

  getNovedadesActaById(id: any): Observable<Acta> {
    return this.http.get<Acta>(`${this.apiUrl}/JrvNovedades/${id}`);
  }

  updateNovedadesItem(id: any, acta: Acta): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/JrvNovedades/${id}`, acta);
  }

  deleteNovedadesItem(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/JrvNovedades/${id}`);
  }

  getActas(): Observable<any> {
    return this.http.get(`${this.apiUrl}/Actas`);
  }
  createActas(data: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/Actas`, data);
  }
}
