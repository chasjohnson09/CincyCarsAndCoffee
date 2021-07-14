import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EastEditComponent } from './east-edit.component';

describe('EastEditComponent', () => {
  let component: EastEditComponent;
  let fixture: ComponentFixture<EastEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EastEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EastEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
