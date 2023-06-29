import { Component } from '@angular/core';
import { UserRegister } from '../models/user-register';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.sass']
})
export class SignupComponent {
  user = new UserRegister();
  errors = new Array();

  protected onSubmit() {
    if (this.user.password !== this.user.passwordConfirm) {
      this.errors.push("Your password mismatch!");
    }
  }
}
