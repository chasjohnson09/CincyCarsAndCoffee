import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NorthListComponent } from './north-list.component';

describe('NorthListComponent', () => {
  let component: NorthListComponent;
  let fixture: ComponentFixture<NorthListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NorthListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NorthListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
