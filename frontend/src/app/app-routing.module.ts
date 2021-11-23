import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddBlogComponent } from './MyComponents/add-blog/add-blog.component';
import { DashboardComponent } from './MyComponents/dashboard/dashboard.component';
import { ForgotPasswordComponent } from './MyComponents/forgot-password/forgot-password.component';
import { LoginComponent } from './MyComponents/login/login.component';
import { NavbarComponent } from './MyComponents/navbar/navbar.component';
import { RegistrationComponent } from './MyComponents/registration/registration.component';


const routes: Routes = [
  {
    path:"",
    component:NavbarComponent
  },
  {
    path:"login",
    component:LoginComponent
  },
  {
    path:"registration",
    component:RegistrationComponent
  },
  {
    path:"add-blog",
    component:AddBlogComponent
  },
  {
    path:"forgot-password",
    component:ForgotPasswordComponent
  },
  {
    path:"dashboard",
    component:DashboardComponent
  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
