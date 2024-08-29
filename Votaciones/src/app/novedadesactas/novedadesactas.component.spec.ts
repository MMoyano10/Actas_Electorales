import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NovedadesactasComponent } from './novedadesactas.component';

describe('NovedadesactasComponent', () => {
  let component: NovedadesactasComponent;
  let fixture: ComponentFixture<NovedadesactasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NovedadesactasComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NovedadesactasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
