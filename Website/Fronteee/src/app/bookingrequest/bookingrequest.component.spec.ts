import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookingrequestComponent } from './bookingrequest.component';

describe('BookingrequestComponent', () => {
  let component: BookingrequestComponent;
  let fixture: ComponentFixture<BookingrequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookingrequestComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BookingrequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
