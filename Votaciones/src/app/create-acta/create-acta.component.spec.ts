import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateActaComponent } from './create-acta.component';

describe('CreateActaComponent', () => {
  let component: CreateActaComponent;
  let fixture: ComponentFixture<CreateActaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateActaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateActaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
