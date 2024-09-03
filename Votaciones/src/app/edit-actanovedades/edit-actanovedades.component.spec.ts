import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditActanovedadesComponent } from './edit-actanovedades.component';

describe('EditActanovedadesComponent', () => {
  let component: EditActanovedadesComponent;
  let fixture: ComponentFixture<EditActanovedadesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditActanovedadesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditActanovedadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
