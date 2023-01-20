import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AcceptedrequestComponent } from './acceptedrequest.component';

describe('AcceptedrequestComponent', () => {
  let component: AcceptedrequestComponent;
  let fixture: ComponentFixture<AcceptedrequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AcceptedrequestComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AcceptedrequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
