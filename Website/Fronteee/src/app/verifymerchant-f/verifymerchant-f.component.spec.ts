import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerifymerchantFComponent } from './verifymerchant-f.component';

describe('VerifymerchantFComponent', () => {
  let component: VerifymerchantFComponent;
  let fixture: ComponentFixture<VerifymerchantFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerifymerchantFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VerifymerchantFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
