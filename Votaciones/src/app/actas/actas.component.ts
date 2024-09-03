import { Component, OnInit } from '@angular/core';
import { NavbarComponent } from '../navbar/navbar.component';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-actas',
  standalone: true,
  imports: [NavbarComponent],
  templateUrl: './actas.component.html',
  styleUrl: './actas.component.css'
})
export class ActasComponent implements OnInit  {
  actas: any[] = [];

  constructor(private actasService: ApiService) {}

  ngOnInit(): void {
    this.actasService.getItems().subscribe(data => {
      this.actas = data;
    });
  }
}
