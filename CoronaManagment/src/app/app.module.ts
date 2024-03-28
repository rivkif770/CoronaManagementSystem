import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { HttpClientModule} from '@angular/common/http';
import { OneClientComponent } from './Components/details-client/one-client.component';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { VaccinComponent } from './Components/vaccin/vaccin.component';
import { SickComponent } from './Components/sick/sick.component';
import { AddClientComponent } from './Components/add-client/add-client.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UpdateClientComponent } from './Components/update-client/update-client.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MatTableModule} from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    OneClientComponent,
    VaccinComponent,
    SickComponent,
    AddClientComponent,
    UpdateClientComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatInputModule,
    ReactiveFormsModule,
    MatDatepickerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
