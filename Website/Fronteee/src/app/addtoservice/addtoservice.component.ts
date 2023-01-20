import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addtoservice',
  templateUrl: './addtoservice.component.html',
  styleUrls: ['./addtoservice.component.scss']
})
export class AddtoserviceComponent implements OnInit {

  constructor(private router:Router) { }
  goToPage(pageName:string):void{
    this.router.navigate([`${pageName}`]);
  
}

  ngOnInit(): void {
  }
}

