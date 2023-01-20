import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../service/auth.service';
import { Useer } from '../useer';

import Swal from 'sweetalert2';

import {NgToastService} from 'ng-angular-popup';

@Component({
  selector: 'app-bookreview',
  templateUrl: './bookreview.component.html',
  styleUrls: ['./bookreview.component.scss']
})
export class BookreviewComponent implements OnInit {

  @ViewChild('toast', { static: true })
  private toast : any  ;

  public time = '10:00:00';
  public mins = '08:15';
  public max = '18:15:30';

  public onValidationFailed() {
      this.toast.open();
  }

  title = 'datePicker';
  currentDate: any = new Date();

  
   
  selectedMatDate!: Date;

  ordinaryDateSelected!: Date;


  disName = false;
  Employeeid: any;
 nn :any;
  mers:any;
  merr:any;
  mercs:any;
  merch:any;
  idtimeRecord! :number;
  status="d";
  tt:any;
  addUserForm!:FormGroup;


  aa:any;
  bb:any;
  cc:any;
  dd:any;
  ee:any;

useer! : Useer;

  constructor(private authservice : AuthService,private route: ActivatedRoute,private router: Router,private formBuilder: FormBuilder,private toast1: NgToastService) { }

  ngOnInit(): void {
    this.addUserForm = this.formBuilder.group(
      {
        data: ['', [Validators.required]],
      });
    this.authservice.currentuser().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        this.tt = res.userName;
        console.log("Results :",res);
      } , (error : any) => {
       //  this.message = 'you are not log in';
        console.log(error.error);
      }
     )

      //this.idtimeRecord = this.route.snapshot.paramMap.get('id');
      this.Employeeid = this.route.snapshot.paramMap.get('id');
      if (this.Employeeid != null && this.Employeeid != 0)
       {
        this.UpdateUser(this.Employeeid);
       }
      
  }
  
  //addUserForm = new FormGroup({
    //data: new FormControl('', [Validators.required]),
    
 // });


  UpdateUser(code :any)
  {
     
    this.authservice.getmerch(code).subscribe((res:any) =>
    {
      this.mers = res;
      this.merch = res.merchSurname;
      this.aa = res.merchName;
      this.bb = res.merchEmail;
      this.cc = res.merchContactdetails;
      this.dd = res.merchCity;
      this.ee = res.merchProvince;
      //this.mers = this.nn.list;
      console.log("Results :",this.mers);
     
    }, (error : any) => {
      
      console.log(error.error);
    }
    
    
    );
  }
  saveUserTyped()
  {


  }
     //this.useer.merchId = this.Employeeid;

  reg()
  {
    let data = {
      "merchId": this.Employeeid,
      "bookDate": this.addUserForm.value.data,
       "bookStatus": this.status
    }

    this.useer = this.addUserForm.value;
     this.authservice.addbooking(data).subscribe((res : any) => {
      console.log("Results :",res);
   this.router.navigateByUrl('home');
    }, (error : any) => {
      console.log(error.error);
    }
    )

  }




  opensweet()
  {
    Swal.fire({
      title: 'Do you want to Send the Request?',
      showDenyButton: true,
      showCancelButton: true,
      confirmButtonText: 'Send',
      denyButtonText: `Don't send`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
         
        let data = {
          "merchId": this.Employeeid,
          "bookDatetime": this.addUserForm.value.data,
           "bookStatus": this.status
        }
    
        this.useer = this.addUserForm.value;
         this.authservice.addbooking(data).subscribe((res : any) => {
          console.log("Results :",res);

          this.toast1.success({detail:"Success Message",summary:"Request Sent Succesfull",duration:15000})
          Swal.fire('Requent Sent!', '', 'success')
          this.router.navigateByUrl('about')
       //this.router.navigateByUrl('home');
        }, (error : any) => {
          console.log(error.error);
        }
        )


        
      
    
    
    
      
       // this.toast.success({detail:"Success Message",summary:"Saved info Succesfull",duration:5000})
      


      } else if (result.isDenied) {
        Swal.fire('Request is Denied', '', 'info')
      }
    })

  }
}
