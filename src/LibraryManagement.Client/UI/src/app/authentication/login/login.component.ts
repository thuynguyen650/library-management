import { Component } from '@angular/core';
import { UserLogin } from '../models/user-login';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent {
  errors = new Array();
  user = new UserLogin();

  constructor(private httpClient: HttpClient) {}

  protected onSubmit() {
    this.httpClient.post("http://localhost:7141/api/authentication/login", this.user)
    .subscribe({
      next: (response) => { console.log(response) },
      error: (error) => { console.log(error) }
    })
  }
}
