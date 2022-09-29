import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import{ Categoria } from './categoria.model';
 
@Injectable({
  providedIn: 'root'
})
export class CategoriasService {

  baseUrl = 'http://localhost:5116/categorias';
  
  constructor(private http:HttpClient) { }

  read(): Observable<Categoria[]> {
    return this.http.get<Categoria[]>(this.baseUrl);
  }
}
