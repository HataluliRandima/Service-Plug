import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PortfolioFComponent } from './portfolio-f.component';

describe('PortfolioFComponent', () => {
  let component: PortfolioFComponent;
  let fixture: ComponentFixture<PortfolioFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PortfolioFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PortfolioFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
