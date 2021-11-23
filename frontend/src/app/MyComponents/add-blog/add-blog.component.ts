import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-blog',
  templateUrl: './add-blog.component.html',
  styleUrls: ['./add-blog.component.css']
})
export class AddBlogComponent implements OnInit {
  textarea:string=""

  constructor() { }

  ngOnInit(): void {
  }

}
// blogContent(){
// console.log('sended'){
//   this.textarea=""
// }
// }