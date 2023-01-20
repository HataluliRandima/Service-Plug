import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderFComponent } from './header-f.component';

describe('HeaderFComponent', () => {
  let component: HeaderFComponent;
  let fixture: ComponentFixture<HeaderFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeaderFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HeaderFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
