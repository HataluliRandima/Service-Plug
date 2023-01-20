import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-single-merchant',
  templateUrl: './single-merchant.component.html',
  styleUrls: ['./single-merchant.component.scss']
})
export class SingleMerchantComponent implements OnInit {

  disName = false;
  Employeeid: any;
 nn :any;
  mers:any;
  merr:any;
  merch:any;
  idtimeRecord! :number;

  numb:any;

tp :any;

ta:any;
tb:any;

 public typc! : string;
 public typrf! : string;

  hata! : number;
 ata : any;
  constructor(private authservice : AuthService,private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe(params =>{
      this.idtimeRecord = +params['id'];
         this.hata  = this.idtimeRecord ;
      console.log("Show ID  :",this.idtimeRecord);
      this.revrev(this.hata);
    })
  
      //this.idtimeRecord = this.route.snapshot.paramMap.get('id');
      this.Employeeid = this.route.snapshot.paramMap.get('id');
      if (this.Employeeid != null && this.Employeeid != 0)
       {
        this.UpdateUser(this.Employeeid);
       
       }
      
       
  }
  UpdateUser(code :any)
  {
     
    this.authservice.getmerch(code).subscribe((res:any) =>
    {
      this.mers = res;
      this.merch = res.merchName;
      this.merr = res.merchSurname;
      this.tp = res.merchType;
      if(this.tp == "ROOFING")
      {
        this.typrf = this.tp;
      }else if ( this.tp = "GARDENING")
      {
        this.typc = this.tp;
      }
      this.ta =res.merchCity;
      this .tb = res.merchProvince;
      this.numb = res.merchContactdetails;
      //this.mers = this.nn.list;
      console.log("Results :",this.mers);
     
    }, (error : any) => {
      
      console.log(error.error);
    }
    
    
    );
  }


  revrev(code : number) 
  {

     this.authservice.getreview(code).subscribe((res : any ) =>
     {
      this.ata = res;
      console.log("Reviews : ", res);
     },(error : any) => {
      
      console.log(error.error);
    });
  }

}
