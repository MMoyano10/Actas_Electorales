import { Component } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-create-acta',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './create-acta.component.html',
  styleUrl: './create-acta.component.css'
})

export class CreateActaComponent {
  newActa: any = {};

  constructor(private actasService: ApiService, private router: Router) {}

  createActa(): void {
    this.actasService.createItem(this.newActa).subscribe(() => {
      this.router.navigate(['/actas']); 
    });
  }
}
