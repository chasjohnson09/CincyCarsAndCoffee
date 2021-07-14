import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NorthEditComponent } from './north-edit.component';

describe('NorthEditComponent', () => {
  let component: NorthEditComponent;
  let fixture: ComponentFixture<NorthEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NorthEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NorthEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
