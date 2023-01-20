import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesttimeComponent } from './testtime.component';

describe('TesttimeComponent', () => {
  let component: TesttimeComponent;
  let fixture: ComponentFixture<TesttimeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TesttimeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TesttimeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
