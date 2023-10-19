import { TestBed } from '@angular/core/testing';

import { InoutboardService } from './inoutboard.service';

describe('InoutboardService', () => {
  let service: InoutboardService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InoutboardService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
