import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactFComponent } from './contact-f.component';

describe('ContactFComponent', () => {
  let component: ContactFComponent;
  let fixture: ComponentFixture<ContactFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContactFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
