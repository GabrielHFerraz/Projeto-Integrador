import { Component, OnInit } from '@angular/core';
import { DadoSensor } from './dadoSensor.model';
import { DadosensorService } from './dadosensor.service';

@Component({
  selector: 'app-dadosensor',
  templateUrl: './dadosensor.component.html',
  styleUrls: ['./dadosensor.component.css']
})
export class DadosensorComponent implements OnInit {
  
  dadoSensor: DadoSensor[] = []
  
  constructor(private dadosensorService: DadosensorService ) { }

  displayedColumns = ['id','valor','status','data_dado'] 

  ngOnInit(): void {
    this.dadosensorService.read().subscribe(dadoSensor =>{this.dadoSensor = dadoSensor});
  }
}
