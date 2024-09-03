import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditActaComponent } from './edit-acta.component';

describe('EditActaComponent', () => {
  let component: EditActaComponent;
  let fixture: ComponentFixture<EditActaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditActaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditActaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
