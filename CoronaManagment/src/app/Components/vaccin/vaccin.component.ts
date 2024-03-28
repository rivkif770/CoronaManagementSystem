import { Component, Input, OnInit } from '@angular/core';
import { Vaccination } from 'src/Classes/Vaccination';
import { VaccinationService } from 'src/Servises/vaccination.service';

@Component({
  selector: 'app-vaccin',
  templateUrl: './vaccin.component.html',
  styleUrls: ['./vaccin.component.scss']
})
export class VaccinComponent implements OnInit {
  
  constructor(
    private vaccinationService: VaccinationService,
  ) { }

  ngOnInit(): void {
    
    this.getAllVaccines();
  }
  
  listVaccines!:Array<Vaccination>
  @Input()IdentityClient!:string
  vaccinForm:boolean=false;
  newVaccin:Vaccination = new Vaccination(0,"",new Date(),"")
  countVaccin!:number
  companies:string[]=[
    "Feizer",
   "Moderna",
   "Astazernika"
  ]
  getAllVaccines(){
    
    this.vaccinationService.GetAllVaccin(this.IdentityClient).subscribe
    ((data:Vaccination[])=>
    {
      this.listVaccines = data;
      console.log(data);
      this.countVaccin = this.listVaccines.length;
    })
    
  }

  OpenVaccinForm()
  {
    this.vaccinForm = true;
  }

  onSubmit(){
    this.newVaccin.idClient = this.IdentityClient;
    console.log(this.IdentityClient);
    this.vaccinationService.AddVaccin(this.newVaccin).subscribe(data=>
      {
        var item = data;
        console.log(data);
        this.ngOnInit();
      })

      
      this.vaccinForm = false;
      this.newVaccin = new Vaccination(0,"",new Date(),"")
  }
}
