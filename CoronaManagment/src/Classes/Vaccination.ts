import { Client } from "./Client";

export class Vaccination{
    constructor(
        public id:number,
        public idClient:string,
        public dateVaccin:Date,
        public nameCompany:string,
        public IdClientNavigation ?: Client
    ){}
}