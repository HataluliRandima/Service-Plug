import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DatepickerFComponent } from './datepicker-f.component';

describe('DatepickerFComponent', () => {
  let component: DatepickerFComponent;
  let fixture: ComponentFixture<DatepickerFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DatepickerFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DatepickerFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
