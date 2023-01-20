import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-merc-single',
  templateUrl: './merc-single.component.html',
  styleUrls: ['./merc-single.component.scss']
})
export class MercSingleComponent implements OnInit {
  disName = false;
  Employeeid: any;
 nn :any;
  mers:any;
  merr:any;
  merch:any;
  idtimeRecord! :number;

  constructor(private authservice : AuthService,private route: ActivatedRoute) { 
   
  }

  ngOnInit(): void {
  this.route.params.subscribe(params =>{
    this.idtimeRecord = +params['id'];
    console.log("Show ID  :",this.idtimeRecord);
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
      //this.mers = this.nn.list;
      console.log("Results :",this.mers);
     
    }, (error : any) => {
      
      console.log(error.error);
    }
    
    
    );
  }


}
