import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validator } from '@angular/forms';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.sass']
})
export class SignupComponent {
  errors = new Array();

  registerForm = new FormGroup({
    email: new FormControl(),
    password: new FormControl(),
    passwordConfirm: new FormControl()
  });

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
