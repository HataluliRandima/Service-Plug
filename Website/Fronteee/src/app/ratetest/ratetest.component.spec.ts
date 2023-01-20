import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RatetestComponent } from './ratetest.component';

describe('RatetestComponent', () => {
  let component: RatetestComponent;
  let fixture: ComponentFixture<RatetestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RatetestComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RatetestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
