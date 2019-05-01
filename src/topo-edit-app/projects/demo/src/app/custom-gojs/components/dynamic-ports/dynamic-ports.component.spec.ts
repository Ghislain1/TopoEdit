import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicPortsComponent } from './dynamic-ports.component';

describe('DynamicPortsComponent', () => {
  let component: DynamicPortsComponent;
  let fixture: ComponentFixture<DynamicPortsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DynamicPortsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DynamicPortsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
