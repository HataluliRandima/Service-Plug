import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TypeofJobsComponent } from './typeof-jobs.component';

describe('TypeofJobsComponent', () => {
  let component: TypeofJobsComponent;
  let fixture: ComponentFixture<TypeofJobsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TypeofJobsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TypeofJobsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
