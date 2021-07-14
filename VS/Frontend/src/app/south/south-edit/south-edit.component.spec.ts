import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SouthEditComponent } from './south-edit.component';

describe('SouthEditComponent', () => {
  let component: SouthEditComponent;
  let fixture: ComponentFixture<SouthEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SouthEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SouthEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
