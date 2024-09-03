import { Component } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-create-actanovedades',
  standalone: true,
  imports: [NavbarComponent],
  templateUrl: './create-actanovedades.component.html',
  styleUrl: './create-actanovedades.component.css'
})

export class CreateJrvComponent {
  newJrv: any = {}; // Objeto para almacenar los datos de la nueva JRV

  constructor(private jrvService: ApiService, private router: Router) {}

  createJrv(): void {
    this.jrvService.createItem(this.newJrv).subscribe(() => {
      this.router.navigate(['/jrv']); // Redirigir a la lista de JRV después de la creación
    });
  }
}
