import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent {
  loginForm = new FormGroup({
    email: new FormControl("", [Validators.required, Validators.email]),
    password: new FormControl("", Validators.required)
  });

  constructor(private httpClient: HttpClient) {}

  protected onSubmit() {
    this.httpClient.post("https://localhost:7141/api/authentication/login", this.loginForm.value)
    .subscribe({
      next: (response) => { console.log(response) },
      error: (error) => {
        this.loginForm.setErrors({ "generalErr": error.error })
      }
    })
  }
}
