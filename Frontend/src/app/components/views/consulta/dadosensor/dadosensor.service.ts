import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DadoSensor } from './dadoSensor.model';

@Injectable({
  providedIn: 'root'
})
export class DadosensorService {

  baseUrl = 'http://localhost:5116/DadosSensor';
  
  constructor(private http:HttpClient) { }

  read(): Observable<DadoSensor[]> {
    return this.http.get<DadoSensor[]>(this.baseUrl);
  }
}
