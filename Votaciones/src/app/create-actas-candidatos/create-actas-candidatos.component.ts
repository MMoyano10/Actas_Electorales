import { Component } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { catchError } from 'rxjs/operators';
import { of } from 'rxjs';
import { ActasCandidatos } from '../actas-candidatos/actas-candidatos.component';

@Component({
  selector: 'app-create-actas-candidatos',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './create-actas-candidatos.component.html',
  styleUrls: ['./create-actas-candidatos.component.css']
})
export class CreateActasCandidatosComponent {
  newActa: ActasCandidatos = {}; 

  constructor(private actasService: ApiService, private router: Router) {}

  createActa(): void {
    this.actasService.createActas(this.newActa).pipe(
      catchError(error => {
        console.error('Error creating acta:', error);
        return of(null); 
      })
    ).subscribe(() => {
      this.router.navigate(['/actas-candidatos']); 
    });
  }

}
