import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ApiService } from 'src/app/shared/api.service';


@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

 public signUpForm !:FormGroup;

  constructor(private fb:FormBuilder,private http:HttpClient,private router:Router,private api:ApiService) { }

  ngOnInit():void {
    this.signUpForm=this.fb.group({
      firstName:['',Validators.required],
      lastName:['',Validators.required],
      email:['',Validators.compose([Validators.required,Validators.email])],
      password:['',Validators.required],
      confirmPassword:['',Validators.required]
    })
    signUp(){
      this.api.signUp(this.signUpForm.value)
      .subscribe(res=>){
        alert(res.message);
        this.signUpForm.reset();
        this.router.navigate(['login'])
      }
    }
  }
}



    
function signUp() {
  throw new Error('Function not implemented.');
}

