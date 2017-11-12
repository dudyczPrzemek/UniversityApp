import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocationAnalizerComponent } from './location-analizer.component';

describe('LocationAnalizerComponent', () => {
  let component: LocationAnalizerComponent;
  let fixture: ComponentFixture<LocationAnalizerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocationAnalizerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocationAnalizerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
