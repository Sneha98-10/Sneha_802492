import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MnotificationsComponent } from './mnotifications.component';

describe('MnotificationsComponent', () => {
  let component: MnotificationsComponent;
  let fixture: ComponentFixture<MnotificationsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MnotificationsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MnotificationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
