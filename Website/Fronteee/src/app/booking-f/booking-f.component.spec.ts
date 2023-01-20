import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookingFComponent } from './booking-f.component';

describe('BookingFComponent', () => {
  let component: BookingFComponent;
  let fixture: ComponentFixture<BookingFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookingFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BookingFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
