import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Client } from 'src/Classes/Client';
import { ClientService } from 'src/Servises/client.service';

@Component({
  selector: 'app-add-client',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.scss']
})
export class AddClientComponent implements OnInit {

  form!: FormGroup;

  constructor(
    private clientService: ClientService,
    private myRouter: Router,
    private formBuilder: FormBuilder
  ) { }

  newClient: Client = new Client(0, "", "", "", "", new Date(), "")
  succes: boolean = false;
  city!: string
  street!: string
  number!: number

  ngOnInit(): void {

    this.form = this.formBuilder.group({
      identity: [null, [Validators.required, Validators.pattern("^[0-9]{7,9}$")]],
      firstName: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,15}$")]],
      lastName: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,15}$")]],
      city: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,25}$")]],
      street: [null, [Validators.required, Validators.pattern("^[a-zA-Z ]{2,25}$")]],
      number: [null, [Validators.required]],
      birthDate: [null, [Validators.required]],
      phone: [null, [Validators.required, Validators.pattern("^[0-9]{9,10}$")]],
    })
  }

  onSubmit() {
    console.log(this.newClient)
    this.newClient.address = this.city + " " + this.street + " " + this.number;

    if (this.newClient.identityClient != "") {

      this.clientService.AddClient(this.newClient).subscribe(data => {
        this.succes = data;
        alert("Client successfully added")
        this.myRouter.navigate(['/']);



      },
        err => {
          console.log(err)
          alert("Identity is not corecct")
          this.form.reset();
        });

    }
  }


}
