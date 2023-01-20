import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-testtime',
  templateUrl: './testtime.component.html',
  styleUrls: ['./testtime.component.scss']
})
export class TesttimeComponent implements OnInit {

  
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
  constructor() { }

  ngOnInit(): void {
  }

}
