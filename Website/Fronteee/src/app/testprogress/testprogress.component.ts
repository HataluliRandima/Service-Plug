import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-testprogress',
  templateUrl: './testprogress.component.html',
  styleUrls: ['./testprogress.component.scss']
})
export class TestprogressComponent implements OnInit {

  name = 'Progress Bar';

  constructor() { }

  ngOnInit(): void {
  }
    //Demo purpose only, Data might come from Api calls/service
    public counts1 = ["Recieved","In Progress","Ready for Billing",
    "Billed","Order Closed"];
    public orderStatus1 = "Billed"
 
  //Demo purpose only, Data might come from Api calls/service
  public counts = ["Recieved","In Progress","Ready for Billing",
  "Billed","Order Closed"];
  public orderStatus = "Recieved"



}
