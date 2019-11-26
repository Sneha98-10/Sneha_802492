import { TestBed } from '@angular/core/testing';

import { SpaymentService } from './spayment.service';

describe('SpaymentService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SpaymentService = TestBed.get(SpaymentService);
    expect(service).toBeTruthy();
  });
});
