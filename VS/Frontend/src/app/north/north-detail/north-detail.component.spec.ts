import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NorthDetailComponent } from './north-detail.component';

describe('NorthDetailComponent', () => {
  let component: NorthDetailComponent;
  let fixture: ComponentFixture<NorthDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NorthDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NorthDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
