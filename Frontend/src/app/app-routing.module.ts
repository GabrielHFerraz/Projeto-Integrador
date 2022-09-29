import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriasComponent } from './components/views/consulta/categorias/categorias.component';
import { SensorReadComponent } from './components/sensor-read/sensor-read.component';
import { DadosensorComponent } from './components/views/consulta/dadosensor/dadosensor.component';

const routes: Routes = [
  {
    path: "categorias",
    component: CategoriasComponent,
   },
   {
    path: "sensores",
    component: SensorReadComponent,
   },
   {
    path:"dadosensor",
    component: DadosensorComponent 
   }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
