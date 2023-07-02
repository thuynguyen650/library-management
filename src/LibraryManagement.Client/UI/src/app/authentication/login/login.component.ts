import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent {
  errors = new Array();
  loginForm = new FormGroup({
    email: new FormControl(),
    password: new FormControl()
  })

  constructor(private httpClient: HttpClient) {}

  protected onSubmit() {
    this.httpClient.post("http://localhost:7141/api/authentication/login", this.loginForm.value)
    .subscribe({
      next: (response) => { console.log(response) },
      error: (error) => { console.log(error) }
    })
  }
}
