import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/template/header/header.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { NavComponent } from './components/template/nav/nav.component';

import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon';
import { SensorReadComponent } from './components/sensor-read/sensor-read.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import {MatMenuModule} from '@angular/material/menu';

import { HttpClientModule } from '@angular/common/http';
import { CadastrarComponent } from './components/template/nav/cadastrar/cadastrar/cadastrar.component';
import { ConsultarComponent } from './components/template/nav/consultar/consultar/consultar.component';
import { CategoriasComponent } from './components/views/consulta/categorias/categorias.component';
import { DadosensorComponent } from './components/views/consulta/dadosensor/dadosensor.component';



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    NavComponent,
    SensorReadComponent,
    CadastrarComponent,
    ConsultarComponent,
    CategoriasComponent,
    DadosensorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    HttpClientModule,
    MatMenuModule
  ],
  exports:[MatMenuModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
