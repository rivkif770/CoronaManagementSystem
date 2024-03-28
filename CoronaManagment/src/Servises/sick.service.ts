import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CountSick } from 'src/Classes/CountSick';
import { Sick } from 'src/Classes/Sick';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SickService {

  constructor(
    private httpClient:HttpClient
  ) { }

  userUrl= `${environment.urlApi}/${'Sick'}`;

  //function to get sick per id
  GetSick(identityClient:string):Observable<Sick>{
    return this.httpClient.get<Sick>(`${this.userUrl}/${'GetSick'}/${identityClient}`)
}

AddSick(sick:Sick):Observable<any>{
  return this.httpClient.post<any>(`${this.userUrl}/${'AddSick'}`,sick)
}

GetCountSick():Observable<number[]>{
  return this.httpClient.get<number[]>(`${this.userUrl}/${'CountSick'}`)
}
}
