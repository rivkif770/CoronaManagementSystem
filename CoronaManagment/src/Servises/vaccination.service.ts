import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Vaccination } from 'src/Classes/Vaccination';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VaccinationService {

  constructor(
    private httpClient:HttpClient
  ) { }


  userUrl= `${environment.urlApi}/${'Vaccination'}`;

  //function to get vaccin per id
  GetAllVaccin(identityClient:string):Observable<Vaccination[]>{
    return this.httpClient.get<Vaccination[]>(`${this.userUrl}/${'GetAllVaccin'}/${identityClient}`)
}

  AddVaccin(vaccination:Vaccination):Observable<any>{
    return this.httpClient.post<any>(`${this.userUrl}/${'AddVaccin'}`,vaccination)
  }
}
