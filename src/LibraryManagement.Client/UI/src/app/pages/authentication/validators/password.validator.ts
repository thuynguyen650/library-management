import { AbstractControl, ValidationErrors } from "@angular/forms";

export function isPasswordMatch(control: AbstractControl): ValidationErrors | null {
    const password = control.get("password")?.value;
    const passwordConfirm = control.get("passwordConfirm")?.value;

    if (password != passwordConfirm) {
        return { "mismatch": true };
    }
    return null;
}