import { TestBed } from '@angular/core/testing';

import { GoogleaddressService } from './googleaddress.service';

describe('GoogleaddressService', () => {
  let service: GoogleaddressService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GoogleaddressService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
