import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminhomeFComponent } from './adminhome-f.component';

describe('AdminhomeFComponent', () => {
  let component: AdminhomeFComponent;
  let fixture: ComponentFixture<AdminhomeFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminhomeFComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminhomeFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
