import { Component, OnInit, ɵflushModuleScopingQueueAsMuchAsPossible } from '@angular/core';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

public registrationForm !:FormGroup
  constructor(private formBuilder:FormBuilder) { }

  ngOnInit():void {
    this.registrationForm=this.formBuilder.group({
      firstName:[''],
      lastName:[""],
      email:[''],
      password:[''],
      conformPassword:['']
    })
  }
}
// Registration(){
//   this.http.get<any>("")
//   .subscribe()
// }
