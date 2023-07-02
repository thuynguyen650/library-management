import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { isPasswordMatch } from '../validators/password.validator';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.sass']
})
export class SignupComponent {
  errors = new Array();

  registerForm = new FormGroup({
    email: new FormControl("", [Validators.required, Validators.email]),
    password: new FormControl("", [Validators.required]),
    passwordConfirm: new FormControl("", [Validators.required])
  },
  [isPasswordMatch]);

  get email() {
    return this.registerForm.get('email');
  }

  get password() {
    return this.registerForm.get('password');
  }

  get passwordConfirm() {
    return this.registerForm.get('passwordConfirm');
  }

  constructor(
    private httpClient: HttpClient,
    private router: Router) {}

  protected onSubmit() {
    console.log(this.registerForm.value);
    if (this.registerForm.get("password")?.value != this.registerForm.get("passwordConfirm")?.value) {
      this.errors.push("Your password mismatch!");
    }

    else {
      this.httpClient.post('https://localhost:7141/api/authentication/register', this.registerForm.value)
      .subscribe({
        next: () => {
          this.router.navigate(["login"]);
        },
        error: (error) => { console.log(error) },
        complete: () => console.log("completed"),
      })
    }
    
  }
}
