import { TestBed } from '@angular/core/testing';

import { AngularTopoEditorService } from './angular-topo-editor.service';

describe('AngularTopoEditorService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AngularTopoEditorService = TestBed.get(AngularTopoEditorService);
    expect(service).toBeTruthy();
  });
});
