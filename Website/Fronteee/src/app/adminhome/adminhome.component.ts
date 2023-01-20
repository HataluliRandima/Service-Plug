import { Component, OnInit } from '@angular/core';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-adminhome',
  templateUrl: './adminhome.component.html',
  styleUrls: ['./adminhome.component.scss']
})
export class AdminhomeComponent implements OnInit {
  message ='';

  mercs : any;

  constructor(private authService : AuthService) { }

  ngOnInit(): void {
    this.authService.getallmerchants().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        console.log("Results :",res);
      } , (error : any) => {
         this.message = 'you are not log in';
        console.log(error.error);
      }
     )
  }

}
