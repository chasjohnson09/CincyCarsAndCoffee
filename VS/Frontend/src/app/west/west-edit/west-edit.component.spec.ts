import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WestEditComponent } from './west-edit.component';

describe('WestEditComponent', () => {
  let component: WestEditComponent;
  let fixture: ComponentFixture<WestEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WestEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WestEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
