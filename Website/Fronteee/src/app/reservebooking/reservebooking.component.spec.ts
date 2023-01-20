import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservebookingComponent } from './reservebooking.component';

describe('ReservebookingComponent', () => {
  let component: ReservebookingComponent;
  let fixture: ComponentFixture<ReservebookingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReservebookingComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReservebookingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
