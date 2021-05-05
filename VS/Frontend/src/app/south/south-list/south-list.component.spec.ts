import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SouthListComponent } from './south-list.component';

describe('SouthListComponent', () => {
  let component: SouthListComponent;
  let fixture: ComponentFixture<SouthListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SouthListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SouthListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
