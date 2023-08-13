import { Component, OnInit } from '@angular/core';
import BookCategory from 'src/app/models/book-category.model';
import AuthorService from 'src/app/services/author.service';
import {
  Select,
  initTE,
} from "tw-elements";

@Component({
  selector: 'app-create-book',
  templateUrl: './create-book.component.html',
  styleUrls: ['./create-book.component.sass']
})
export class CreateBookComponent implements OnInit {
  authors: BookCategory[] = [];

  constructor(private authorService: AuthorService) {
  }

  ngOnInit () {
    // Initialization for ES Users
    initTE({ Select });
    this.getAllAuthors();
  }

  getAllAuthors(): void {
    this.authorService.getAllAuthors()
    .subscribe({
      next: res => this.authors = res as BookCategory[],
      error: err => console.log(err)
    });
  }
}
