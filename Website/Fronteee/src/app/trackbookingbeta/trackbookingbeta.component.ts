import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { observeOn } from 'rxjs';
import Swal from 'sweetalert2';
import { Merchant } from '../merchant';
import { AuthService } from '../service/auth.service';


@Component({
  selector: 'app-trackbookingbeta',
  templateUrl: './trackbookingbeta.component.html',
  styleUrls: ['./trackbookingbeta.component.scss']
})
export class TrackbookingbetaComponent implements OnInit {
 //for rating
 rating3: number;
 //public form: FormGroup;

 addUserForm!:FormGroup;

  mercs:any;
  idtimeRecord! :number;
  merr:any;
  aa:any;
  ss:any;
  bb:any;
  Employeeid:any;

  jk:any;

  merss:any;
  mers:any;
  merch:any;
  ma:any;
  me:any;

iddd:any;

  qat:any;

  public op = "Booking";
  public opp = "Booking confirmed";
  public oppp= "Service";
  public opppp = "Service completed";


  public raterev : any;

  gj:any;

idtest :any;
mntest: any ;
mstest: any;

ads:any;

  ep:any;

  public os ! : string;
hat: any;
ata: any;

empList: Array<any> = [];

nametest! :string;

  arr11: Merchant[] = [];

  a11 = {} as Merchant;

ggg:any;
hata :any;
ch:any;

show! :boolean  ;
  constructor(private authService : AuthService,private route: ActivatedRoute,private fb: FormBuilder,private toast1: NgToastService,private router: Router) {


    this.rating3 = 0;
    // this.form = this.fb.group({
    //   rating1: ['', Validators.required],
    //   rating2: [4]
    // });


   }

  //Demo purpose only, Data might come from Api calls/service
  public counts = ["Booking","Booking confirmed","Service","Service completed"];
  public orderStatus!: string  ;
 
  public orderStatus1!: string  ;

  ngOnInit(): void {
    this.route.params.subscribe(params =>{
      this.idtimeRecord = +params['id'];
      console.log("Show ID ffff  :",this.idtimeRecord);
    })
    this.Employeeid = this.route.snapshot.paramMap.get('id');
    if (this.Employeeid != null && this.Employeeid != 0)
     {
     
      console.log("Show ID ewe :",this.Employeeid);
     }
let data =
{
  "merchId":this.bb,
}
    this.authService.getstatusbooking().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        this.merr  = res.bookDate;
        this.aa = res.bookId;
        this.ss = res.bookStatus;
        this.iddd = res.merchId;
        console.log("aaa : " ,this.ss)
        console.log("merch id : " ,this.iddd)
        this.bb = res.merchId;
       this.orderStatus = "Booking";
      // this.os = "Booking ";
       //this.op="Booking";
        var n = 1;
        var numbers = [1, 2, 3];

        //The loop to see if gives 1 merchant
        for (let test11 of this.mercs)
        {
          this.idtest = test11.merchId;

          console.log("Test id is : ",this.idtest)

          this.authService.getmerch(this.idtest).subscribe((res : any) =>
          {
              this.mstest = res;
             
              
              this.a11.merchName = this.mstest.merchName;

              this.mntest = this.mstest.merchName;

                //add array
                //public ejhe = ["Booking","Booking confirmed","Service","Service completed"];
              
                this.empList.push( this.mstest  );

                this.arr11.push(this.a11);

                console.log("prayer : ", this.empList);

                this.ads = this.mntest;
                console.log("yah : ",this.ads)
              console.log("Madzina : ",this.mstest)
              console.log("Merchant Name : ",this.mntest)
          })
          
        }


        for (n; n<  this.mercs.length; n++) {
            var num =  this.mercs[n];
            this.bb = res.merchId;
            this.jk =n;
            
            console.log("zwino:",this.jk);
        }
        this.UpdateUser(this.jk);
        console.log("Results :",res);
        if (this.bb != null && this.bb != 0)
        {
        this.UpdateUser(this.bb);
        }
        else
        {
          console.log("Asizwone : " ,  this.mercs)
        }
      } , (error : any) => {
        // this.message = 'you are not log in';
        console.log(error.error);
      }
     )


 
     this.authService.getidstatus(data).subscribe((res :any) =>
     {
       this.ata = res;
       console.log("Khezwi : ", res);
     })

 
     this.addUserForm = this.fb.group(
      {
        rating1: ['', [Validators.required]],
        ratingmessage: ['', [Validators.required]],
         
      });
    

  }

  pp(data:any)
  {
    this.authService.getidstatus(data).subscribe((res :any) =>
    {
      this.ata = res;
      console.log("Khezwi : ", res);
    })
  }


  oo()
  {
    this.authService.getstatusactive().subscribe((res : any ) =>
    {
       this.hat = res;
       console.log("Active results : ", res);
       this.ata = res.bookStatus;
       if(this.ata = "Active"){
         this.show = true;
      //   this.os = "Booking confirmed";
        // this.orderStatus = "Booking confirmed";
         console.log("zwoita ")
       }
       else{
         this.show = false;
         console.log("not the same ")
       }
      
    }, (error : any) => {
     // this.message = 'you are not log in';
     console.log(error.error);
   }
    )

    this.orderStatus="Booking confirmed"
  }
  UpdateUser(code :number)
  {
   
    this.authService.getmerch(code).subscribe((res:any) =>
    {
      this.mers = res;
     // this.merch = res.merchName;
      this.me = res.merchSurname;
      //this.mers = this.nn.list;
      console.log("Available :",this.mers);
     
    }, (error : any) => {
      
      console.log(error.error);
    }
    
    
    );
  }
  now(data:number)
  {
    this.authService.getmerch(data).subscribe((res:any) =>
    {
      this.mers = res;
      this.merch = res.merchName;
      this.ma = res.merchSurname;
      //this.mers = this.nn.list;
      console.log("Available :",this.ma);
     
    }, (error : any) => {
      
      console.log(error.error);
    }
    
    
    );
  }

  saw(data:number)
  {
    this.authService.getquot(data).subscribe((res:any)=>
    {
   this.qat = res;

   console.log("Quotations : ", this.qat);
    },(error:any) =>
    {
      console.log(error.error);
    }
    
    )

  }
   //Demo purpose only, Data might come from Api calls/service
   public counts1 = ["Booking","Booking confirmed", 
   "Service in Progress","Service Done"];
   public orderStatus11! : string;
  paw(data:number)
  {
    this.authService.checkstaus(data).subscribe((res:any)=>
    {
   this.qat = res;
     this.ep = res.bookStatus;
     this.gj = res.userId;
     console.log("d ",this.gj);
     if(this.ep== "Active")
     {
      this.orderStatus11="Booking confirmed";
     }
     else if(this.ep == "InActive")
     {
      this.orderStatus11="Booking";
     }
  
   console.log("Tracking : ", this.ep);
    },(error:any) =>
    {
      console.log("error.error");
    }
    
    )



    //mine for job status starting here to check

    this.authService.checkjobstaus(data).subscribe((res : any )=>
      {
               this.hata =res;
               this.ch = res.jobStatus;
             this.ggg = res.jobId;
               if(this.ch=="Active")
               {
                this.orderStatus11="Service in Progress";
               } else if(this.ch=="Service Done")
               {
                this.orderStatus11="Service Done";
                this.raterev="Service Done";
               }
               console.log("job status : ",this.ch);
      })

  }
  //the post method of adding the rate and its message 
  ratee(data11 : any)
  {
//     let data = {
 
//       "jobId": 5,
//       "merchId": this.gj,
//       "reviewMessage": this.addUserForm.value.ratingmessage,
//       "reviewRating": "3",
      
       
//     }
// console.log(data);
//     this.authService.addratemessage(data).subscribe((res : any) => {
//       console.log("Rate Results :",res);

    
    
//     }, (error : any) => {
//       console.log(error.error);
//     }
//     )

    Swal.fire({
      title: 'Do you want to Rate the Merchant?',
      showDenyButton: true,
      showCancelButton: true,
      confirmButtonText: 'Rate',
      denyButtonText: `Don't Rate`,
    }).then((result) => {
    
      if (result.isConfirmed) {
         
        let data = {
          "jobId": 5,
          "merchId": this.gj,
          "reviewMessage": this.addUserForm.value.ratingmessage,
          "reviewRating": "3",
        }
  
        this.authService.addratemessage(data).subscribe((res : any) => {
           
          console.log("Rate Results :",res);


          this.toast1.success({detail:"Success Message",summary:"Rate Sent Succesfull",duration:15000})
          Swal.fire('Rate Sent!', '', 'success')
          this.router.navigateByUrl('homef')
        
        }, (error : any) => {
          console.log(error.error);
        }
        )

      } else if (result.isDenied) {
        Swal.fire('Request is Denied', '', 'info')
      }
    })

  }

}
