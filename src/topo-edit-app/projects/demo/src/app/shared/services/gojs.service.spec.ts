import { TestBed } from '@angular/core/testing';

import { GojsService } from './gojs.service';

describe('GojsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GojsService = TestBed.get(GojsService);
    expect(service).toBeTruthy();
  });
});
