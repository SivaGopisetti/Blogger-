import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './MyComponents/login/login.component';
import { NavbarComponent } from './MyComponents/navbar/navbar.component';
import { AddBlogComponent } from './MyComponents/add-blog/add-blog.component';
import { RegistrationComponent } from './MyComponents/registration/registration.component';
import { ForgotPasswordComponent } from './MyComponents/forgot-password/forgot-password.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './MyComponents/dashboard/dashboard.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ApiService } from './shared/api.service';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavbarComponent,
    AddBlogComponent,
    RegistrationComponent,
    ForgotPasswordComponent,
    DashboardComponent,
   

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
