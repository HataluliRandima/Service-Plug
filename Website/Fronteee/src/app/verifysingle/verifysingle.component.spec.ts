import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerifysingleComponent } from './verifysingle.component';

describe('VerifysingleComponent', () => {
  let component: VerifysingleComponent;
  let fixture: ComponentFixture<VerifysingleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerifysingleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VerifysingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
