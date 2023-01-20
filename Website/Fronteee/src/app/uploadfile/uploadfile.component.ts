import { HttpClient, HttpErrorResponse, HttpEventType, HttpRequest, HttpResponse } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { EventManager } from '@angular/platform-browser';
import { JwtHelperService } from '@avatsaev/angular-jwt';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-uploadfile',
  templateUrl: './uploadfile.component.html',
  styleUrls: ['./uploadfile.component.scss']
})
export class UploadfileComponent implements OnInit {

  public progress! :number

  public message! : string
  test:any;

 an : any ;
  mess = ''
mercs :any;

  public files :any;

 @Output() public onUploadFinished = new EventEmitter();
  submissionResult: any;
   


  constructor(private http : HttpClient,private auth : AuthService,private jwtHelper: JwtHelperService) { }

  ngOnInit(): void {
    this.auth.currentmerchant().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        console.log("Results :",res);
      } , (error : any) => {
         this.mess = 'you are not log in efefefef';
        console.log(error.error);
      }
     )
  }


  handlefileinput(event: Event)
  {
    let files = (event.target as HTMLInputElement).files;
    if(files)
    {
      for(let index = 0;index< files.length;index++)
      {
        if(files.item(index))
        {
           this.postfile(files.item(index) as File);
        }
      }
    }

    (event.target as HTMLInputElement).files = null;
    (event.target as HTMLInputElement).value ="";
  }

  postfile(file : File) 
  { 
    this.isUserAuthenticated();
    let data  = 
    {
      "merchFile":file
    }
    this.auth.postfile(file).subscribe((res: any) => {
   this.test = res;
   console.log(this.test);
    });

  }
  
  isUserAuthenticated = (): boolean => {
    const token = localStorage.getItem("token");

    if (token && !this.jwtHelper.isTokenExpired(token)){
      return true;
    }

    return false;
  }

  jh()
  {
    let data = 
    {
        merchTaxnumber:'544346'
    }
    this.auth.editmerchtax(data).subscribe((res : any) => {
      this.an = res;
      console.log("Khedzi : ",res);
    })

  }

  logout()
  {
    localStorage.removeItem("token");
    alert('Your session expired');
    localStorage.clear();
  }
}
