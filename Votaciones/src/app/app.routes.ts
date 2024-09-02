import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ActasComponent } from './actas/actas.component';
import { NovedadesactasComponent } from './novedadesactas/novedadesactas.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './auth.guard';

export const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] }, // Ruta protegida
  { path: 'actas', component: ActasComponent, canActivate: [AuthGuard] },
  { path: 'novedadesactas', component: NovedadesactasComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent }
];

export class AppRoutingModule { }
