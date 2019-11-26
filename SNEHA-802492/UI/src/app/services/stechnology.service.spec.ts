import { TestBed } from '@angular/core/testing';

import { StechnologyService } from './stechnology.service';

describe('StechnologyService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StechnologyService = TestBed.get(StechnologyService);
    expect(service).toBeTruthy();
  });
});
