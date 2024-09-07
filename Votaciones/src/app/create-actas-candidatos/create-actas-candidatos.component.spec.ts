import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateActasCandidatosComponent } from './create-actas-candidatos.component';

describe('CreateActasCandidatosComponent', () => {
  let component: CreateActasCandidatosComponent;
  let fixture: ComponentFixture<CreateActasCandidatosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateActasCandidatosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateActasCandidatosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
