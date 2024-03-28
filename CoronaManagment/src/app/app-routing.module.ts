import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddClientComponent } from './Components/add-client/add-client.component';
import { OneClientComponent } from './Components/details-client/one-client.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { UpdateClientComponent } from './Components/update-client/update-client.component';

const routes: Routes = [
  
   { path: "", component: HomePageComponent},
   { path: "Add-Client", component: AddClientComponent},
   {path: "Update-Client", component: UpdateClientComponent},
   {path: ":Id-Client", component: OneClientComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes),CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
