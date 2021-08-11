import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InputStudentComponent } from './input-student.component';

describe('InputStudentComponent', () => {
  let component: InputStudentComponent;
  let fixture: ComponentFixture<InputStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InputStudentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InputStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
