import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SouthDetailComponent } from './south-detail.component';

describe('SouthDetailComponent', () => {
  let component: SouthDetailComponent;
  let fixture: ComponentFixture<SouthDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SouthDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SouthDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
