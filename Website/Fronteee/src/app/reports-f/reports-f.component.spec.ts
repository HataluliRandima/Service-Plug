import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportsFComponent } from './reports-f.component';

describe('ReportsFComponent', () => {
  let component: ReportsFComponent;
  let fixture: ComponentFixture<ReportsFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportsFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReportsFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
