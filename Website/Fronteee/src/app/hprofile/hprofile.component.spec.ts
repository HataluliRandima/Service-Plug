import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HprofileComponent } from './hprofile.component';

describe('HprofileComponent', () => {
  let component: HprofileComponent;
  let fixture: ComponentFixture<HprofileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HprofileComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HprofileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
