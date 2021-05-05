import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WestListComponent } from './west-list.component';

describe('WestListComponent', () => {
  let component: WestListComponent;
  let fixture: ComponentFixture<WestListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WestListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WestListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
