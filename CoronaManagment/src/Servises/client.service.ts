import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Client } from 'src/Classes/Client';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private httpClient:HttpClient) { }

  clientList:Client[] = [];
  clientUpdate!:Client

  userUrl= `${environment.urlApi}/${'Client'}`;
  
  GetListClients():Observable<Client[]>{
    return this.httpClient.get<Client[]>(`${this.userUrl}/${'GetAllClients'}`)
  }

  GetClient(idClient:number):Observable<Client>{
    return this.httpClient.get<Client>(`${this.userUrl}/${'GetClient'}/${idClient}`)
  }

  AddClient(newClient:Client):Observable<any>{
    return this.httpClient.post<any>(`${this.userUrl}/${'AddClient'}`,newClient)
  }


  DeleteClient(identityClient:string):Observable<any>{
    return this.httpClient.delete<any>(`${this.userUrl}/${'DeletClient'}/${identityClient}`)
  }

  UpdateClient(id:number,updateClient:Client):Observable<any>{
    return this.httpClient.put<any>(`${this.userUrl}/${'UpdateClient'}/${id}`,updateClient)
  }

  CountUnvaccinated():Observable<number>{
    return this.httpClient.get<number>(`${this.userUrl}/${'CountUnvaccinated'}`);
  }


  GetClientById(idClient:number)
  {  
    return this.clientList.find(x=> x.id==idClient)
  }
}
