import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get('https://localhost:7141/api/Users')
    .subscribe(
      (response) => {
        // Handle the successful response here
        console.log(response);
      },
      (error) => {
        // Handle any errors that occurred during the request
        console.error(error);
      }
    );
  }
  title: string = 'My Library';
}
