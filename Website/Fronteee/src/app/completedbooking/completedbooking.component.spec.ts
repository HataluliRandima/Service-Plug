import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompletedbookingComponent } from './completedbooking.component';

describe('CompletedbookingComponent', () => {
  let component: CompletedbookingComponent;
  let fixture: ComponentFixture<CompletedbookingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompletedbookingComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompletedbookingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
