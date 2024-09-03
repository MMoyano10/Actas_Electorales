import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from '../api.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-edit-actanovedades',
  standalone: true,
  imports: [CommonModule,FormsModule,NavbarComponent,],
  templateUrl: './edit-actanovedades.component.html',
  styleUrl: './edit-actanovedades.component.css'
})
export class EditActanovedadesComponent {
  novedadesActa: any;

  constructor(
    private route: ActivatedRoute,
    private actasService: ApiService,
    private router: Router
  ) {}

  ngOnInit(): void {
    // Obtener el ID del acta de la URL
    const id = this.route.snapshot.paramMap.get('id');
    
    // Obtener la información del acta por ID
    this.actasService.getNovedadesActaById(id).subscribe(
      (data) => {
        this.novedadesActa = data;
      },
      (error) => {
        console.error('Error al obtener el acta:', error);
      }
    );
  }

  save(): void {
    if (this.novedadesActa) {
      this.actasService.updateItem(this.novedadesActa.idJrv, this.novedadesActa).subscribe(
        () => {
          this.router.navigate(['/novedadesactas']);
        },
        (error) => {
          console.error('Error al guardar el acta:', error);
        }
      );
    }
  }

  cancel(): void {
    this.router.navigate(['/novedadesactas']);
  }
}
