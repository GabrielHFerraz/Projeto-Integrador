import { Component, OnInit } from '@angular/core';
import { SensorService } from './sensor.service';
import { Sensor } from './sensor.model';

@Component({
  selector: 'app-sensor-read',
  templateUrl: './sensor-read.component.html',
  styleUrls: ['./sensor-read.component.css']
})
export class SensorReadComponent implements OnInit {
  
  sensors: Sensor[] = []
  
  constructor(private sensorService: SensorService ) { }

  displayedColumns = ['id','nome','tipo'] 

  ngOnInit(): void {
    this.sensorService.read().subscribe(sensors =>{this.sensors = sensors});
  }

}
