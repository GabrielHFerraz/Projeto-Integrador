import { HttpBackend, HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Sensor } from './sensor.model';


@Injectable({
  providedIn: 'root'
})
export class SensorService {

  baseUrl = 'http://localhost:5116/sensores'
  
  constructor(private http:HttpClient) { }

  read(): Observable<Sensor[]> {
    return this.http.get<Sensor[]>(this.baseUrl);
  }

}
