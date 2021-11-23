// import { Injectable } from '@angular/core';
// import {HttpClient} from '@angular/common/http';
// import { pipe } from 'rxjs';
// import {map} from 'rxjs/operators'


// @Injectable({
//   providedIn: 'root'
// })
// export class ApiService {

//   public registrationApiUrl:string =""

//   constructor(private _http:HttpClient) { }

//   PostBlog(data:any){
//     return this._http.post<any>("http:localhost:3000/posts",data)
//     .pipe(map((res:any)=>{
//       return res;
//     }))
//   }
//   DeleteBlog(Id:number){
//     return this._http.delete<any>("http:localhost:3000/posts"+id)
//     .pipe(map((res:any)=>{
//       return res;
//     }))
//   }
//   UpdateBlog(Id:number,data:any){
//     return this._http.put<any>("http:localhost:3000/posts"+id,data)
//     .pipe(map((res:any)=>{
//       return res;
//     }))
//   }
//   GetBlog(Id:number,data:any){
//     return this._http.get<any>("http:localhost:3000/posts"+id,data)
//     .pipe(map((res:any)=>{
//       return res;
//     }))
//   }
//   registration(userObj:any){
//     return this._http.post<any>(`${this.loginApiUrl}registration`,userObj)
//   }
// }
