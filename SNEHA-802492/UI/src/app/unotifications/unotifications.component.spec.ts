import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnotificationsComponent } from './unotifications.component';

describe('UnotificationsComponent', () => {
  let component: UnotificationsComponent;
  let fixture: ComponentFixture<UnotificationsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UnotificationsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnotificationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
