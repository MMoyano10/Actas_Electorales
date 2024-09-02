import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})

export class LoginComponent {
  username: string = '';
  password: string = '';
  errorMessage: string | null = null;

  constructor(private router: Router) { }

  onSubmit() {
    if (this.username === 'Admin' && this.password === 'admin') {
      // Marca al usuario como autenticado
      localStorage.setItem('isLoggedIn', 'true');
      // Redirige al usuario a la página de inicio después del login
      this.router.navigate(['/home']);
    } else {
      // Muestra un mensaje de error si las credenciales son incorrectas
      this.errorMessage = 'Invalid username or password';
    }
  }
}