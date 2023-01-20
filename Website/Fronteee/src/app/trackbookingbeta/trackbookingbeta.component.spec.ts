import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackbookingbetaComponent } from './trackbookingbeta.component';

describe('TrackbookingbetaComponent', () => {
  let component: TrackbookingbetaComponent;
  let fixture: ComponentFixture<TrackbookingbetaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrackbookingbetaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TrackbookingbetaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
