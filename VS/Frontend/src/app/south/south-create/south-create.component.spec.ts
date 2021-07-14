import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SouthCreateComponent } from './south-create.component';

describe('SouthCreateComponent', () => {
  let component: SouthCreateComponent;
  let fixture: ComponentFixture<SouthCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SouthCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SouthCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
