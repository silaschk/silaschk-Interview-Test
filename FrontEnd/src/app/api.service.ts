import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private apiBaseUrl = 'http://localhost:4201';

  constructor(private http: HttpClient) {}

  getHeroes(): Observable<any[]> {
    const url = `${this.apiBaseUrl}/heroes`;
    return this.http.get<any[]>(url);
  }

  evolveHero(heroName: string): Observable<any> {
    const url = `${this.apiBaseUrl}/heroes/evolve`;
    const action = { name: heroName, action: 'evolve' };
    return this.http.post<any>(url, action);
  }
}
