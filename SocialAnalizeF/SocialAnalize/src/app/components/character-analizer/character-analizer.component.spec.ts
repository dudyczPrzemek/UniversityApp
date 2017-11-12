import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterAnalizerComponent } from './character-analizer.component';

describe('CharacterAnalizerComponent', () => {
  let component: CharacterAnalizerComponent;
  let fixture: ComponentFixture<CharacterAnalizerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CharacterAnalizerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CharacterAnalizerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
