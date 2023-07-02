import { Component } from '@angular/core';
import { UserRegister } from '../models/user-register';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.sass']
})
export class SignupComponent {
  user = new UserRegister();
  errors = new Array();

  constructor(
    private httpClient: HttpClient,
    private router: Router) {}

  protected onSubmit() {
    if (this.user.password !== this.user.passwordConfirm) {
      this.errors.push("Your password mismatch!");
    }

    else {
      this.httpClient.post('https://localhost:7141/api/authentication/register', this.user)
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
