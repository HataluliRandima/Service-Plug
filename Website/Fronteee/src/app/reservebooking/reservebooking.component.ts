import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
//import { Router } from '@angular/router';

@Component({
  selector: 'app-reservebooking',
  templateUrl: './reservebooking.component.html',
  styleUrls: ['./reservebooking.component.scss']
})
export class ReservebookingComponent implements OnInit {

  constructor(private router:Router) { }
  goToPage(pageName:string):void{
    this.router.navigate([`${pageName}`]);
  
}

  ngOnInit(): void {
  }

}
