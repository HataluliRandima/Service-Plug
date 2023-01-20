import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { JwtHelperService } from '@avatsaev/angular-jwt';
import { Observable } from 'rxjs';
import { AuthService } from '../service/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthaaGuard implements CanActivate {


  constructor (private router : Router,private jwtHelper: JwtHelperService,private authservice : AuthService){

  }


  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
 
      
      const token = localStorage.getItem("session");

     // if (token && !this.jwtHelper.isTokenExpired(token)){
       // console.log(this.jwtHelper.decodeToken(token))
    //    return true;
      //}
  
      //this.router.navigate(["signin"]);

    



    let isLoggedIn = this.authservice.isAuthenticated();
    if (isLoggedIn){
     
      this.router.navigate(["signin"]);
    } else {
      return false;
    }
    return true;
  }
  
}
