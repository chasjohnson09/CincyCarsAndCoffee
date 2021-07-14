import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EastCreateComponent } from './east-create.component';

describe('EastCreateComponent', () => {
  let component: EastCreateComponent;
  let fixture: ComponentFixture<EastCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EastCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EastCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
