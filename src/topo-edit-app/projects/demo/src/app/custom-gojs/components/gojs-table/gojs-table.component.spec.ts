import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GojsTableComponent } from './gojs-table.component';

describe('GojsTableComponent', () => {
  let component: GojsTableComponent;
  let fixture: ComponentFixture<GojsTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GojsTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GojsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
