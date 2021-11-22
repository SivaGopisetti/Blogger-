import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email="";
  password="";
  valid={
    email:true,
    password:true,
  };

 

  ngOnInit():void {}
  validate(type: string): void {
    const emailPattern = /\S+@\S+\.\S+/;

    if (type === 'email') {
      this.valid.email = emailPattern.test(this.email);
    } else if(type === ('password')) {
      if (this.password !== this.password) {
        this.valid.password = false;
      } else {
        this.valid.password = true;
      }
    }
  }

  onKey(event: any, type: string) {
    if (type === 'email') {
      this.email = event.target.value;
    } else if (type === 'password'){
      this.password = event.target.value;
    } 
    this.validate(type);
  }
}
    
  
 



