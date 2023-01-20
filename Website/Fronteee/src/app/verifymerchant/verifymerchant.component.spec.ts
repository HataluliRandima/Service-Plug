import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerifymerchantComponent } from './verifymerchant.component';

describe('VerifymerchantComponent', () => {
  let component: VerifymerchantComponent;
  let fixture: ComponentFixture<VerifymerchantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerifymerchantComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VerifymerchantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
