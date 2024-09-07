import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActasCandidatosComponent } from './actas-candidatos.component';

describe('ActasCandidatosComponent', () => {
  let component: ActasCandidatosComponent;
  let fixture: ComponentFixture<ActasCandidatosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ActasCandidatosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ActasCandidatosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
