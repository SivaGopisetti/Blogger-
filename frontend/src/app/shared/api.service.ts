import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { pipe } from 'rxjs';
import {map} from 'rxjs/operators'


@Injectable({
  providedIn: 'root'
})
export class ApiService {

  public loginApiUrl:string =" "

  constructor( private _http:HttpClient) { }

  PostBlog(data:any){
    return this._http.post<any>("",data)
    .pipe(map((res:any)=>{
      return res;
    }))
  }
  DeleteBlog(Id:number){
    return this._http.delete<any>(""+Id)
    .pipe(map((res:any)=>{
      return res;
    }))
  }
  UpdateBlog(Id:number,data:any){
    return this._http.put<any>(""+Id,data)
    .pipe(map((res:any)=>{
      return res;
    }))
  }
  GetBlog(Id:number,data:any){
    return this._http.get<any>(""+Id,data)
    .pipe(map((res:any)=>{
      return res;
    }))
  }
  signUp(userObj:any){
    return this._http.post<any>(`${this.loginApiUrl}signUp`,userObj)
  }
}
