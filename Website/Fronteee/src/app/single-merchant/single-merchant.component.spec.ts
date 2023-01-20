import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleMerchantComponent } from './single-merchant.component';

describe('SingleMerchantComponent', () => {
  let component: SingleMerchantComponent;
  let fixture: ComponentFixture<SingleMerchantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleMerchantComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SingleMerchantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
