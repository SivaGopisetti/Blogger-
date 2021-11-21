import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  this.registrationForm=this.formBuilder.group({
    firstname:['',Validators.required],
    lastname:['',Validators.required],
    email:['',Validators.required],
    password:['',Validators.required],
    confirmPassword:['',Validators.required],

  });

  constructor() { }

  ngOnInit():void {
    
  }

}
