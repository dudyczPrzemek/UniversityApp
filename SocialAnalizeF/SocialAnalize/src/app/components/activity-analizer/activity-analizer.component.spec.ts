import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivityAnalizerComponent } from './activity-analizer.component';

describe('ActivityAnalizerComponent', () => {
  let component: ActivityAnalizerComponent;
  let fixture: ComponentFixture<ActivityAnalizerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActivityAnalizerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActivityAnalizerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
