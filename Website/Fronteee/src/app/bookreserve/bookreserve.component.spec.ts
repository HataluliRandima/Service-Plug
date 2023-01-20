import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookreserveComponent } from './bookreserve.component';

describe('BookreserveComponent', () => {
  let component: BookreserveComponent;
  let fixture: ComponentFixture<BookreserveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookreserveComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BookreserveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
