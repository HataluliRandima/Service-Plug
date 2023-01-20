import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { saveAs } from 'file-saver';
import { NgToastService } from 'ng-angular-popup';
import { AuthService } from '../service/auth.service';

import Swal from 'sweetalert2';

@Component({
  selector: 'app-verifymerchant-f',
  templateUrl: './verifymerchant-f.component.html',
  styleUrls: ['./verifymerchant-f.component.scss']
})
export class VerifymerchantFComponent implements OnInit {

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
  


  constructor(private http:  HttpClient,private authservice : AuthService,private route: ActivatedRoute,private toast: NgToastService,private router:Router,private formBuilder: FormBuilder) { 
    this.getAllFiles();
  }
  files: any = [];
  getAllFiles()
  {
     
    return this.http.get('https://localhost:7271/api/Managers/getNotverifiedMerch')
    .subscribe((result) => {
      this.files = result;
      console.log(result);
  });
  }
  downloadFile(id: number, contentType: string)
  {
    return this.http.get(`https://localhost:7271/api/Files/download/${id}`, {responseType: 'blob'})
    .subscribe((result: Blob) => {
      const blob = new Blob([result], { type: contentType });
       saveAs(blob, contentType);
      console.log(result);
  });
  }
  ngOnInit(): void {
  }

  opensweet( code : any)
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
        //this.submitted = true;

      //  if (this.form.invalid) {
        //  return;
        //} 
    
      //  console.log(JSON.stringify(this.form.value, null, 2));
    
        let data = {
          "merchVerify":"Active"  
         
      }
    //
      this.authservice.editmerchstatus(code,data).subscribe((res : any) => {
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
        this.router.navigateByUrl('verifyf')
      } else if (result.isDenied) {
        Swal.fire('Merchant  not verified', '', 'info')
      }
    })
}

}
