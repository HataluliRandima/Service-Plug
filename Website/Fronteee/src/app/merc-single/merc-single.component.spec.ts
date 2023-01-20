import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MercSingleComponent } from './merc-single.component';

describe('MercSingleComponent', () => {
  let component: MercSingleComponent;
  let fixture: ComponentFixture<MercSingleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MercSingleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MercSingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
