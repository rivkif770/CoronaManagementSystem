import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Client } from 'src/Classes/Client';
import { ClientService } from 'src/Servises/client.service';

@Component({
  selector: 'app-update-client',
  templateUrl: './update-client.component.html',
  styleUrls: ['./update-client.component.scss']
})
export class UpdateClientComponent implements OnInit {

  form!: FormGroup;

  constructor(
    private clientService:ClientService,
    private myRouter:Router,
    private formBuilder: FormBuilder
  ) { }

  client!:Client;
  succesUpdate:boolean = false;
  updateClient!:Client;

  ngOnInit(): void {

    this.form = this.formBuilder.group({
      firstName: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,15}$")]],
      lastName: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,15}$")]],
      address: [null, [Validators.required]],
      birthDate: [null, [Validators.required]],
      phone: [null, [Validators.required, Validators.pattern("^[0-9]{9,10}$")]],
      mobilePhone:[]
    })
    this.client = this.clientService.clientUpdate;
    console.log(this.client);
    this.updateClient = {...this.client}
  }

  onSubmit(){
    this.clientService.UpdateClient(this.updateClient.id,this.updateClient).subscribe(data=>
      {
          this.succesUpdate = data;
          console.log(data);
          console.log(this.updateClient)
          alert("Client successfully Updated")
          this.myRouter.navigate(['/']);
      })

      
  }
}
