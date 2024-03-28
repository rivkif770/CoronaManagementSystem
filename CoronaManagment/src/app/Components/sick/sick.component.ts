import { Component, Input, OnInit } from '@angular/core';
import { Sick } from 'src/Classes/Sick';
import { SickService } from 'src/Servises/sick.service';

@Component({
  selector: 'app-sick',
  templateUrl: './sick.component.html',
  styleUrls: ['./sick.component.scss']
})
export class SickComponent implements OnInit {

  constructor(
    private sickService:SickService
  ) { }

  ngOnInit(): void {
    this.getSick()
  }

  @Input()IdentityClient!:string
  
  Currentsick!:Sick
  newSick:Sick = new Sick(0,"",new Date(),new Date())
  succesAddSick:boolean = false;
  openForm:boolean = false;

  getSick(){
    this.sickService.GetSick(this.IdentityClient).subscribe(data=>
      {
        this.Currentsick = data;
        console.log(this.Currentsick);
      })
}

onSubmit(){
  this.newSick.idClient = this.IdentityClient;
  this.sickService.AddSick(this.newSick).subscribe(data=>
    {
      this.succesAddSick = data;
      console.log(this.succesAddSick);
      if(this.succesAddSick)
      {
        this.ngOnInit();
      }
    })
    this.openForm = false;
}

OpenForm()
{
  this.openForm = true;
}

}
