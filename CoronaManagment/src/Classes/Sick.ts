import { Client } from "./Client";

export class Sick{
    constructor(
        public id:number,
        public idClient:string,
        public datePositive:Date,
        public dateRecovery:Date,
        public udClientNavigation?:Client
    ){}
}