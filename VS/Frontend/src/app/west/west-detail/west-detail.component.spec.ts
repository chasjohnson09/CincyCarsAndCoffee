import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WestDetailComponent } from './west-detail.component';

describe('WestDetailComponent', () => {
  let component: WestDetailComponent;
  let fixture: ComponentFixture<WestDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WestDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WestDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
