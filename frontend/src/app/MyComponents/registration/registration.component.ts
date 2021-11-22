import { Component, OnInit, ɵflushModuleScopingQueueAsMuchAsPossible } from '@angular/core';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  firstName='';
  lastName='';
  email='';
  password="";
  confirmPassword="";
  valid={
    firstName:true,
    lastName:true,
    email:true,
    password:true,
    confirmPassword:true,
  }

  constructor() { }

  ngOnInit():void {}

    validate(type: string): void {
      const firstNamePattern = /^[\w-.]*$/;
      const laststNamePattern = /^[\w-.]*$/;
      const emailPattern = /\S+@\S+\.\S+/;
  
      if (type === 'firstName') {
        if (this.firstName.length < 5) {
          this.valid.firstName= false;
        } else {
          this.valid.firstName = firstNamePattern.test(this.firstName);
        }
      } else if (type === 'lastName') {
        if (this.firstName.length < 5) {
          this.valid.firstName= false;
        } else {
          this.valid.firstName = laststNamePattern.test(this.firstName);
        }
      } 
      else if (type === 'emai') {
        this.valid.email = emailPattern.test(this.email);
      } else if (type === ('confirmPassword' || 'password')) {
        if (this.password !== this.confirmPassword) {
          this.valid.password = false;
        } else {
          this.valid.password = true;
        }
      }
    }
  
    onKey(event: any, type: string) {
      if (type === 'firstName') {
        this.firstName = event.target.value;
      } else if (type === 'laststName') {
        this.firstName = event.target.value;
      } else if (type === 'email') {
        this.email = event.target.value;
      } else if (type === 'password') {
        this.password = event.target.value;
      } else if (type === 'confirmPassword') {
        this.confirmPassword = event.target.value;
      }
      this.validate(type);
    }
  }
  
