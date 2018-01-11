import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddStartPageComponent } from './add-start-page.component';

describe('AddStartPageComponent', () => {
  let component: AddStartPageComponent;
  let fixture: ComponentFixture<AddStartPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddStartPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddStartPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
