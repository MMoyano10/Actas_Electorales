import { Component } from '@angular/core';
import { NavbarComponent } from '../navbar/navbar.component';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';

export interface NovedadesActas {
  idNovedades?: number;
  descripcionNovedad?: string;
  referencia1Novedades?: string;
  referencia2Novedades?: string;
  idJrv?: string;
  idRegion?: string;
  idProvincia?: string;
  idCanton?: number;
  idParroquia?: string;
  idRecinto?: string;
}

@Component({
  selector: 'app-novedadesactas',
  standalone: true,
  imports: [NavbarComponent,CommonModule],
  templateUrl: './novedadesactas.component.html',
  styleUrls: ['./novedadesactas.component.css']
})
export class NovedadesactasComponent {

  novedadesActas: NovedadesActas[] = [];

  constructor(private actasService: ApiService, private router: Router) {}

  ngOnInit(): void {
    this.actasService.getNovedadesActas().subscribe(data => {
      console.log('Datos recibidos:', data); 
      this.novedadesActas = data;
    });
  }

  // Método para redirigir al formulario de creación
  createActa(): void {
    this.router.navigate(['/create-actanovedades']);
  }

  // Método para redirigir al formulario de edición
  editActa(id: any): void {
    this.router.navigate([`/edit-actanovedades/${id}`]);
  }

  // Método para eliminar un acta
  deleteActa(id: any): void {
    if (confirm('¿Estás seguro de que deseas eliminar esta acta?')) {
      this.actasService.deleteItem(id).subscribe(() => {
        this.novedadesActas = this.novedadesActas.filter(a => a.idNovedades !== id);
      });
    }
  }
}
