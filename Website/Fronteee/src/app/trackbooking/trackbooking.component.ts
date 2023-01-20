import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-trackbooking',
  templateUrl: './trackbooking.component.html',
  styleUrls: ['./trackbooking.component.scss']
})
export class TrackbookingComponent implements OnInit {
  mercs:any;
  idtimeRecord! :number;
  merr:any;
  aa:any;
  ss:any;
  bb:any;


  qat:any;

  public op = "Booking";
  public opp = "Booking confirmed";
  public oppp= "Service";
  public opppp = "Service completed";


  ep:any;

  public os ! : string;
hat: any;
ata: any;
  constructor(private authService : AuthService,private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.route.params.subscribe(params =>{
      this.idtimeRecord = +params['id'];
      console.log("Show ID  :",this.idtimeRecord);
    })

    this.authService.getstatusbooking().subscribe(
      (res : any) => {
        // this.message = `Welcome ${res.userName}`;
        this.mercs = res;
        this.merr  = res.bookDatetime;
        this.aa = res.bookId;
        this.ss = res.bookStatus;
        this.bb = res.merchId;
        console.log("Results :",res);
      } , (error : any) => {
        // this.message = 'you are not log in';
        console.log(error.error);
      }
     )
  }
    //Demo purpose only, Data might come from Api calls/service
    public counts1 = ["Booking","Booking confirmed", 
    "Service","Service completed"];
    public orderStatus1! : string;

    
  paw(data:number)
  {
    this.authService.checkstaus(data).subscribe((res:any)=>
    {
   this.qat = res;
     this.ep = res.bookStatus;
     if(this.ep== "Active")
     {
      this.orderStatus1="Booking confirmed";
     }
     else{
      this.orderStatus1="Booking";
     }
  
   console.log("Tracking : ", this.ep);
    },(error:any) =>
    {
      console.log("error.error");
    }
    
    )

  }

}
