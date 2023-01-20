import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackbookingComponent } from './trackbooking.component';

describe('TrackbookingComponent', () => {
  let component: TrackbookingComponent;
  let fixture: ComponentFixture<TrackbookingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrackbookingComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TrackbookingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
