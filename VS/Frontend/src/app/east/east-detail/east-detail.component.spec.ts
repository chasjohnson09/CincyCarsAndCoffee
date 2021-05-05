import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EastDetailComponent } from './east-detail.component';

describe('EastDetailComponent', () => {
  let component: EastDetailComponent;
  let fixture: ComponentFixture<EastDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EastDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EastDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
