import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WestCreateComponent } from './west-create.component';

describe('WestCreateComponent', () => {
  let component: WestCreateComponent;
  let fixture: ComponentFixture<WestCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WestCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WestCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
