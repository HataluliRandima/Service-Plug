import { Component, OnInit } from '@angular/core';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-adminhome-f',
  templateUrl: './adminhome-f.component.html',
  styleUrls: ['./adminhome-f.component.scss']
})
export class AdminhomeFComponent implements OnInit {

  message ='';

  mercs : any;

  aa : any;
  constructor(private authService : AuthService) { }

  ngOnInit(): void {
    this.authService.getallmerchants().subscribe(
      (res : any) => {      
        this.mercs = res;
        console.log("Results :",res);
      } , (error : any) => {
         this.message = 'you are not log in';
        console.log(error.error);
      }
     )

     this.authService.getbookingsnumber().subscribe((res:any) =>
     {
        this.aa = res;
     })
  }

}
