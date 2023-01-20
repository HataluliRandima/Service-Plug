import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
//import {Router} from '@angular/router';

@Component({
  selector: 'app-typeof-jobs',
  templateUrl: './typeof-jobs.component.html',
  styleUrls: ['./typeof-jobs.component.scss']
})
export class TypeofJobsComponent implements OnInit {

  constructor(private router:Router) { }
    goToPage(pageName:string):void{
      this.router.navigate([`${pageName}`]);
    
  }
  ngOnInit(): void {
  }

}
