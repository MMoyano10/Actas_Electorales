import { Component, OnInit } from '@angular/core';
import { Acta } from '../actas/actas.component';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from '../api.service';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from '../navbar/navbar.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-edit-acta',
  standalone: true,
  imports: [CommonModule,FormsModule,NavbarComponent,],
  templateUrl: './edit-acta.component.html',
  styleUrl: './edit-acta.component.css'
})

export class EditActaComponent implements OnInit {
  acta: any;

  constructor(
    private route: ActivatedRoute,
    private actasService: ApiService,
    private router: Router
  ) {}

  ngOnInit(): void {
    // Obtener el ID del acta de la URL
    const id = this.route.snapshot.paramMap.get('id');
    
    // Obtener la información del acta por ID
    this.actasService.getActaById(id).subscribe(
      (data) => {
        this.acta = data;
      },
      (error) => {
        console.error('Error al obtener el acta:', error);
      }
    );
  }

  save(): void {
    if (this.acta) {
      this.actasService.updateItem(this.acta.idJrv, this.acta).subscribe(
        () => {
          this.router.navigate(['/actas']);
        },
        (error) => {
          console.error('Error al guardar el acta:', error);
        }
      );
    }
  }

  cancel(): void {
    this.router.navigate(['/actas']);
  }
}

