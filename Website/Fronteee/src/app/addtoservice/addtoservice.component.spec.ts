import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddtoserviceComponent } from './addtoservice.component';

describe('AddtoserviceComponent', () => {
  let component: AddtoserviceComponent;
  let fixture: ComponentFixture<AddtoserviceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddtoserviceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddtoserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
