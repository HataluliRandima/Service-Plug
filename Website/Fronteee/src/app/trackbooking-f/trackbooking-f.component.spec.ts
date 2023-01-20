import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackbookingFComponent } from './trackbooking-f.component';

describe('TrackbookingFComponent', () => {
  let component: TrackbookingFComponent;
  let fixture: ComponentFixture<TrackbookingFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrackbookingFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TrackbookingFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
