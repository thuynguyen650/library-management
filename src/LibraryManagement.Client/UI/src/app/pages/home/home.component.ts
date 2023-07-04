import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  books: any;

  constructor(private httpClient: HttpClient) {}

  ngOnInit(): void {
    this.httpClient.get("https://localhost:7141/api/books")
    .subscribe({
      next: (res) => {
        this.books = res;
      },
      error: (err) => console.log(err)
    })
  }         
}
