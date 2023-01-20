import { TestBed } from '@angular/core/testing';

import { AuthaaGuard } from './authaa.guard';

describe('AuthaaGuard', () => {
  let guard: AuthaaGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AuthaaGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
