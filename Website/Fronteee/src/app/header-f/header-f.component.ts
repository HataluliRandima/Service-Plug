import { Component, OnInit } from '@angular/core';
import { JwtHelperService } from '@avatsaev/angular-jwt';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-header-f',
  templateUrl: './header-f.component.html',
  styleUrls: ['./header-f.component.scss']
})
export class HeaderFComponent implements OnInit {
  message ='';

  mercs : any;


  constructor(private jwtHelper: JwtHelperService,private authService : AuthService) { }

  ngOnInit(): void {
    this.authService.currentuser().subscribe(
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
  isUserAuthenticated = (): boolean => {
    const token = localStorage.getItem("jwt");

    if (token && !this.jwtHelper.isTokenExpired(token)){
      return true;
    }

    return false;
  }

  logOut = () => {
    localStorage.removeItem("jwt");
    alert('Your session expired');
    localStorage.clear();
  }

}
