import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ContactService {


  constructor() { }
  contacts:any[]=[];
  newContact:any={};
  addContact()
  {
    this.contacts.push(this.newContact);
    this.newContact={};
    
  }
}
