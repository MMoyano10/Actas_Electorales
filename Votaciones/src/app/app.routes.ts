import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ActasComponent } from './actas/actas.component';
import { NovedadesactasComponent } from './novedadesactas/novedadesactas.component';

export const routes: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'actas', component: ActasComponent },
    { path: 'novedadesactas', component: NovedadesactasComponent }
  ];
