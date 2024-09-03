import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ActasComponent } from './actas/actas.component';
import { NovedadesactasComponent } from './novedadesactas/novedadesactas.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './auth.guard';
import { CreateActaComponent } from './create-acta/create-acta.component';
import { EditActaComponent } from './edit-acta/edit-acta.component';
import { EditActanovedadesComponent } from './edit-actanovedades/edit-actanovedades.component';

export const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
  { path: 'actas', component: ActasComponent, canActivate: [AuthGuard] },
  { path: 'novedadesactas', component: NovedadesactasComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'create-acta', component: CreateActaComponent, canActivate: [AuthGuard] },
  { path: 'edit-acta/:id', component: EditActaComponent, canActivate: [AuthGuard] },
  {path: 'create-actanovedades', component: CreateActaComponent, canActivate: [AuthGuard]},
  {path: 'edit-actanovedades/:id', component: EditActanovedadesComponent, canActivate: [AuthGuard]}
];

export class AppRoutingModule { }
