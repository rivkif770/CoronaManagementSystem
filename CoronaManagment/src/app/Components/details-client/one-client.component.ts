import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Client } from 'src/Classes/Client';
import { Vaccination } from 'src/Classes/Vaccination';
import { ClientService } from 'src/Servises/client.service';
import { VaccinationService } from 'src/Servises/vaccination.service';

@Component({
  selector: 'app-one-client',
  templateUrl: './one-client.component.html',
  styleUrls: ['./one-client.component.scss']
})
export class OneClientComponent implements OnInit {
  
  constructor(
    private myActiveRout:ActivatedRoute,
    private clientService:ClientService,
    private vaccinationService: VaccinationService,
    ) { }

  idClient!:number
  currentClient!:Client
  

  ngOnInit(): void {
    
    this.myActiveRout.params.subscribe
    (
      
      data=>{
        this.idClient = data["Id-Client"]
   
       console.log(this.idClient)
        } 
    )
    
    this.getClient();
    console.log(this.currentClient)
    
  }

  getClient(){
    this.clientService.GetClient(this.idClient).subscribe((data)=>
    {
      this.currentClient = data;
      console.log(this.currentClient);
    })
  }

  
}
