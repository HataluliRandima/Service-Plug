import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { UserInfo } from '../user';
import { Observable } from 'rxjs';
import { Useer } from '../useer';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  public readonly tokenName : string = "token";

  constructor(private http: HttpClient,private router: Router) { }
  
  userLogin (data: any)
  {
    return this.http.post(`${environment.apiUrl}/Users/clientlogin`,data);
  }

  merchantlogin (data: any)
  {
    return this.http.post(`${environment.apiUrl}/Merchants/merchantlogin`,data);
  }
 
  userRegister(data: any)
  {
    return this.http.post(`${environment.apiUrl}/Users/clientregister`,data);
  }

  currentuser()
  {
     return this.http.get(`${environment.apiUrl}/Users/users/current`);
  }


  currentmerchant()
  {
     return this.http.get(`${environment.apiUrl}/Merchants/merchant/current`);
  }
  getallmerchants()
  {
    return this.http.get(`${environment.apiUrl}/Merchants/getmerchants`)
  }
 
  userinfo(code :any)
  {
     return this.http.get(`${environment.apiUrl}/Users/users/`+code);
  }

  merchinfo(code:any)
 {
    return this.http.get(`${environment.apiUrl}/Merchants/merchby/`+code);
 }

 merchinfoverify(code:any)
 {
    return this.http.get(`${environment.apiUrl}/Managers/singnotverified/`+code);
 }
  editinfo(code : any,data : any)
  {
     return this.http.put(`${environment.apiUrl}/Users/edituser/`+code,data);
  }

  editmerchstatus(code : any,data : any)
  {
     return this.http.put(`${environment.apiUrl}/Managers/editmerchstatus/`+code,data);
  }
  editmerchtax( data : any)
  {
     return this.http.put(`${environment.apiUrl}/Merchants/editmerchant`,data);
  }


  searchmerchant(data:any,now :any)
  {
    return this.http.get(`${environment.apiUrl}/Merchants/MerchantsLocation?location=`+data+`&type=`+now);
    //https://localhost:7096/api/Merchants/MerchantsLocation?location=nn&type=hh
  }

  addbooking (data:any)
  {
    return this.http.post(`${environment.apiUrl}/Bookings/addbookings`,data);
  }

  addrequest (user:Useer): Observable<Useer>
  {
    return this.http.post<Useer>(`${environment.apiUrl}/Bookings/addbookings`,user);
  }

   getmerch(code:any)
   {
      return this.http.get(`${environment.apiUrl}/Merchants/merchby/`+code);
   }

   getquot(code:any)
   {
     return this.http.get(`${environment.apiUrl}/Quotations/getquotatio/`+code);
   }

getstatusbooking()
{
   return this.http.get(`${environment.apiUrl}/Users/getstatusbook`);
}


getstatusactive ()
{
  return this.http.get(`${environment.apiUrl}/Users/getstatusactive`);
}

getidstatus (code:any)
{
    return this.http.get(`${environment.apiUrl}Users/statusby/`+code)
}


checkstaus(code:any)
{
   return this.http.get(`${environment.apiUrl}/Users/getbokstatus/`+code)
}


checkjobstaus(code:any)
{
   return this.http.get(`${environment.apiUrl}/Users/getjobstatus/`+code)
}
postfile(filetoupload : File) : Observable<Object>
{
  const formdata = new  FormData();
  formdata.append('file',filetoupload);
  const headers = new HttpHeaders().append('Content-Disposition','multipart/form-data');

  return this.http.put(`${environment.apiUrl}/Files/uploadimage`,formdata,{headers});

    

}
  Logout() {
    alert('Your session expired')
    localStorage.clear();
    this.router.navigateByUrl('/login');
  }



  //Start here methods for the managers 
  getbookingsnumber()
  {
    return this.http.get(`${environment.apiUrl}/Bookings/getallbookingsNO`);
  }


  //Method for adding the rate and its messsage by the client to merchant
  addratemessage (data:any)
  {
    return this.http.post(`${environment.apiUrl}/Reviews/addreview`,data);
  }

//Pull the reviews of a merchant by a client
getreview (code:number)
  {
    return this.http.get(`${environment.apiUrl}/Reviews/getreview/`+code);
  }
 



  IsLogged() {
    return localStorage.getItem("token") != null;
  }
  GetToken() {
    return localStorage.getItem("token") || '';
  }
    isLoggedIn = true;
  isAuthenticated(){
    
    return this.isLoggedIn;
  }
}
