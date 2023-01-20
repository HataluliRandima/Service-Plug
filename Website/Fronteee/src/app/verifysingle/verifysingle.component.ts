import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { AuthService } from '../service/auth.service';

import Swal from 'sweetalert2';

 

@Component({
  selector: 'app-verifysingle',
  templateUrl: './verifysingle.component.html',
  styleUrls: ['./verifysingle.component.scss']
})
export class VerifysingleComponent implements OnInit {
  form!: FormGroup;
  submitted = false;


  Employeeid: any;
  EditData: any;

  disName = false;
 
 nn :any;
  mers:any;
  merr:any;
  merch:any;
  idtimeRecord! :number;

tp :any;

ta:any;
tb:any;
  saveresp: any;
  message='';
  messageclass='';
  


  constructor( private authservice : AuthService,private route: ActivatedRoute,private toast: NgToastService,private router:Router,private formBuilder: FormBuilder) {
    this.Employeeid = this.route.snapshot.paramMap.get('id');
    if (this.Employeeid != null && this.Employeeid != 0)
     {
      this.UpdateUser(this.Employeeid);
     }
   }

   ngOnInit(): void {
    this.form = this.formBuilder.group(
      {
     
        merchVerify: ['', [Validators.required]],
      },
      
    );
  }

   UpdateUser(code :any)
   {
     this.authservice.merchinfoverify(code).subscribe((res:any) =>{
     this.EditData = res;
 ;
     this.merch = res.merchName;
     this.merr = res.merchSurname;
     this.tp = res.merchType;
     this.ta =res.merchCity;
     this .tb = res.merchProvince;
 
   });
   }

   profileForm = new FormGroup({
   
    
    merchStatus: new FormControl('', Validators.required)
     
  });


  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }

  opensweet()
  {
 

    Swal.fire({
      title: 'Do you want to verifiy the merchant?',
      showDenyButton: true,
      showCancelButton: true,
      confirmButtonText: 'verify',
      denyButtonText: `Don't verify`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.submitted = true;

        if (this.form.invalid) {
          return;
        } 
    
        console.log(JSON.stringify(this.form.value, null, 2));
    
        let data = {
          "merchVerify": this.form.value.merchVerify
         
      }
    //
      this.authservice.editmerchstatus(this.Employeeid,data).subscribe((res : any) => {
        this.saveresp = res;
        if (this.saveresp.result == 'pass') {
          this.toast.success({detail:"Success Message",summary:"Verified Merchant Succesfull",duration:5000})
          this.message = "Saved Sucessfully"
          this.messageclass = 'sucess'
         
        } else {
          this.message = "save failed"
          this.messageclass = 'error'
        }
        this.toast.success({detail:"Success Message",summary:"Verified Merchant Succesfull",duration:5000})
        this.message = "Saved Sucessfully"
        console.log("Results :",res);
         
     
      }, (error : any) => {
        this.message = "Please enter valid data"
        this.messageclass = 'error'
        console.log(error.error);
      }
      )
        this.toast.success({detail:"Success Message",summary:"Merchant verified Succesfull",duration:5000})
        Swal.fire('Saved!', '', 'success')
        this.router.navigateByUrl('admin')
      } else if (result.isDenied) {
        Swal.fire('Merchant  not verified', '', 'info')
      }
    })
}
get merchStatus() {
  return this.profileForm.get('merchStatus');
}
 
}