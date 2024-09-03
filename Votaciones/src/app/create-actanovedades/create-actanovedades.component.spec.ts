import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateActanovedadesComponent } from './create-actanovedades.component';

describe('CreateActanovedadesComponent', () => {
  let component: CreateActanovedadesComponent;
  let fixture: ComponentFixture<CreateActanovedadesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateActanovedadesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateActanovedadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
