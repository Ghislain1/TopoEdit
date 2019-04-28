import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AngularTopoEditorComponent } from './angular-topo-editor.component';

describe('AngularTopoEditorComponent', () => {
  let component: AngularTopoEditorComponent;
  let fixture: ComponentFixture<AngularTopoEditorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AngularTopoEditorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AngularTopoEditorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
