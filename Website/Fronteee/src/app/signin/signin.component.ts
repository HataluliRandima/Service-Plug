import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../service/auth.service';

import {NgToastService} from 'ng-angular-popup';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.scss']
})
export class SigninComponent implements OnInit {

  form!: FormGroup;
  submitted = false;

  invalidLogin!: boolean;
 hj :any =1;
  


  constructor(private formBuilder: FormBuilder,private router : Router,
    private authService : AuthService, private toast: NgToastService) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group(
      {
     
        email: ['', [Validators.required, Validators.email]],
        password: [
          '',
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(40)
          ]
        ]
      },
      
    );
  }

  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }

  onSubmit() {
    this.submitted = true;

    if (this.form.invalid) {
      return;
    }
  
    console.log(JSON.stringify(this.form.value, null, 2));

    let data = {
       "userEmail": this.form.value.email,
       "userPassword": this.form.value.password
    }


    let data11 = {
      "merchEmail": this.form.value.email,
      "merchPassword": this.form.value.password
   }

  if(this.form.value.email=="manager@gmail.com" && this.form.value.password=="123456")
  {
    localStorage.setItem("session",'admin');
    this.authService.isAuthenticated();
    this.router.navigateByUrl('adminf');
  }
  else   {

  
    this.authService.userLogin(data).subscribe((res : any) => {
      const token = (<any>res).token;
      localStorage.setItem("jwt",token);
      this.invalidLogin = false;
      this.toast.success({detail:"Success Message",summary:"Login Succesfull",duration:5000})
      console.log("Results :",res);
      this.router.navigateByUrl('homef')
   //this.router.navigate(['../home'] ,{ relativeTo: this.route });
    }, (error : any) => {
      this.invalidLogin = true;
      this.toast.error({detail:"Error Message",summary:"Login Failed Please verify",duration:15000})
      console.log(error.error);
    }
    )

  


  }
 
  
   
}



}
