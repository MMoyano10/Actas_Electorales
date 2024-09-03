import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';
import { ApiService } from '../api.service';
import { CommonModule } from '@angular/common';

export interface Acta {
  idJrv?: number;
  nombreRegion?: string;
  nombreProvincia?: string;
  nombreCanton?: string;
  nombreParroquia?: string;
  nombreRecinto?: string;
  descripcionJrv?: string;
  votantesmJrv?: number;
  votantesfJrv?: string;
  coordinadorJrv?: string;
  observacionesJrv?: string;
  adicionalesJrv?: string;
  archivoJrv?: string;
  imagenJrv?: string;
}

@Component({
  selector: 'app-actas',
  standalone: true,
  imports: [NavbarComponent, CommonModule],
  templateUrl: './actas.component.html',
  styleUrls: ['./actas.component.css'] 
})
export class ActasComponent implements OnInit  {
  actas: Acta[] = [];

  constructor(private actasService: ApiService, private router: Router) {}

  ngOnInit(): void {
    this.actasService.getItems().subscribe(data => {
      console.log('Datos recibidos:', data); 
      this.actas = data;
    });
  }

  // Método para redirigir al formulario de creación
  createActa(): void {
    this.router.navigate(['/create-acta']);
  }

  // Método para redirigir al formulario de edición
  editActa(id: any): void {
    this.router.navigate([`/edit-acta/${id}`]);
  }

  // Método para eliminar un acta
  deleteActa(id: any): void {
    if (confirm('¿Estás seguro de que deseas eliminar esta acta?')) {
      this.actasService.deleteItem(id).subscribe(() => {
        this.actas = this.actas.filter(a => a.idJrv !== id);
      });
    }
  }
}
