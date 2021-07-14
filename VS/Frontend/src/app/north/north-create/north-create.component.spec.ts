import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NorthCreateComponent } from './north-create.component';

describe('NorthCreateComponent', () => {
  let component: NorthCreateComponent;
  let fixture: ComponentFixture<NorthCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NorthCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NorthCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
