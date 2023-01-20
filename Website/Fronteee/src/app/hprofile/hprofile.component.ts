import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-hprofile',
  templateUrl: './hprofile.component.html',
  styleUrls: ['./hprofile.component.scss']
})
export class HprofileComponent implements OnInit {

  mercs : any;

  constructor( private router: Router,private authService : AuthService) { }

  ngOnInit(): void {
    this.authService.currentuser().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        console.log("Results :",res);
      } , (error : any) => {
      //   this.message = 'you are not log in';
        console.log(error.error);
      }
     )
  }

}
