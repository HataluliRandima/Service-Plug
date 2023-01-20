import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutusFComponent } from './aboutus-f.component';

describe('AboutusFComponent', () => {
  let component: AboutusFComponent;
  let fixture: ComponentFixture<AboutusFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AboutusFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AboutusFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
