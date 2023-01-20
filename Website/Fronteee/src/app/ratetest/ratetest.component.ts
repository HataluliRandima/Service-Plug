import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-ratetest',
  templateUrl: './ratetest.component.html',
  styleUrls: ['./ratetest.component.scss']
})
export class RatetestComponent implements OnInit {

  rating3: number;
  public form: FormGroup;

  constructor(private fb: FormBuilder) { 
    this.rating3 = 0;
    this.form = this.fb.group({
      rating1: ['', Validators.required],
      rating2: [4]
    });
  }

  ngOnInit(): void {
  }

}
