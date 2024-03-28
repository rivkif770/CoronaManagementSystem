import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Client } from 'src/Classes/Client';
import { ClientService } from 'src/Servises/client.service';
import { SickService } from 'src/Servises/sick.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  constructor(
    private clientService:ClientService,
    private myRouter:Router,
    private sickService:SickService) { }

  listClients:Client[]=[]
  succesDelete:boolean = false;
  listCountSick!:number[]
  month:number = new Date().getMonth();


  ngOnInit(): void {
    this.GetAllClients()
    console.log(this.listClients)
    this.GetCountSick();
    this.CountUnvaccinated();
  }

  GetAllClients()
  {
    this.clientService.GetListClients().subscribe((data:Client[])=>
    {
      this.listClients = data;
      console.log(data);
      console.log(this.listClients)
      this.clientService.clientList = this.listClients;
    }

    )
  }

  Details(id:number)
  {
    this.myRouter.navigate(['/'+id]);
  }

  DeleteClient(identityClient:string){
    this.clientService.DeleteClient(identityClient).subscribe(data=>
      {
        this.succesDelete = data;
        alert("Customer successfully Deleted")
        this.ngOnInit();
      })
      
  }

  UpdateClient(updateClient:Client)
  {
    console.log(updateClient)
    this.clientService.clientUpdate = updateClient;
    this.myRouter.navigate(['/Update-Client']);
  }

  GetCountSick()
  {
    this.sickService.GetCountSick().subscribe(data=>
      {
        this.listCountSick = data;
        console.log(this.listCountSick);
      })
  }

  countUnvaccinated !:number;

  CountUnvaccinated()
  {
    this.clientService.CountUnvaccinated().subscribe(data=>
      {
         this.countUnvaccinated= data;
        console.log(this.listCountSick);
      })
  }


}