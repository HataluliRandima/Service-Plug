import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-date-picker',
  templateUrl: './date-picker.component.html',
  styleUrls: ['./date-picker.component.scss']
})
export class DatePickerComponent implements OnInit {

  constructor(private router:Router) { }
  goToPage(pageName:string):void{
    this.router.navigate([`${pageName}`]);
  
}

  ngOnInit(): void {
  }
}
