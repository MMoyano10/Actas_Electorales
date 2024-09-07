import { Component } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';
import { CommonModule } from '@angular/common';

export interface ActasCandidatos {
  idActa?: number;
  descripcionActa?: string;
  idRegion?: string;
  idProvincia?: string;
  idCanton?: string;
  idParroquia?: string;
  idRecinto?: string;
  idJrv?: string;
  candidato1Jrv?: string;
  candidato2Jrv?: string;
  candidato3Jrv?: string;
  candidato4Jrv?: string;
  candidato5Jrv?: string;
  candidato6Jrv?: string;
  candidato7Jrv?: string;
  candidato8Jrv?: string;
  candidato9Jrv?: string;
  candidato10Jrv?: string;
  candidato11Jrv?: string;
  candidato12Jrv?: string;
  candidato13Jrv?: string;
  candidato14Jrv?: string;
  candidato15Jrv?: string;
  candidato16Jrv?: string;
  candidato17Jrv?: string;
  candidato18Jrv?: string;
  candidato19Jrv?: string;
  candidato20Jrv?: string;
  nulosJrv?: string;
  blancosJrv?: string;
  observacionecsJrv?: string;
  totalPadronJrv?: string;
  totalEleccionJrv?: string;
}


@Component({
  selector: 'app-actas-candidatos',
  standalone: true,
  imports: [NavbarComponent, CommonModule],
  templateUrl: './actas-candidatos.component.html',
  styleUrl: './actas-candidatos.component.css'
})
export class ActasCandidatosComponent {
  actasCandidatos: ActasCandidatos[] = [];

  constructor(private actasService: ApiService, private router: Router) {}

  ngOnInit(): void {
    this.actasService.getActas().subscribe(data => {
      console.log('Datos recibidos:', data); 
      this.actasCandidatos = data;
    });
  }

  // Método para redirigir al formulario de creación
  createActa(): void {
    this.router.navigate(['/create-actas-candidatos']);
  }

  // Método para redirigir al formulario de edición
  editActa(id: any): void {
    this.router.navigate([`/edit-acta/${id}`]);
  }

  // Método para eliminar un acta
  deleteActa(id: any): void {
    if (confirm('¿Estás seguro de que deseas eliminar esta acta?')) {
      this.actasService.deleteItem(id).subscribe(() => {
        this.actasCandidatos = this.actasCandidatos.filter(a => a.idActa !== id);
      });
    }
  }


}
