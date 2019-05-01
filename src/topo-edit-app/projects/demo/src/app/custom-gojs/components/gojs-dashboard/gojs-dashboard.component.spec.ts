import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GojsDashboardComponent } from './gojs-dashboard.component';

describe('GojsDashboardComponent', () => {
  let component: GojsDashboardComponent;
  let fixture: ComponentFixture<GojsDashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GojsDashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GojsDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
