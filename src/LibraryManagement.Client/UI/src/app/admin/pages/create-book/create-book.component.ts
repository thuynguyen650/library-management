import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm } from '@angular/forms';
import Author from 'src/app/models/author.model';
import BookCategory from 'src/app/models/book-category.model';
import AuthorService from 'src/app/services/author.service';
import BookCategoryService from 'src/app/services/book-category.service';
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
  authors: Author[] = [];
  bookCategories: BookCategory[] = [];
  
  bookCreateForm: FormGroup = new FormGroup({
    detailsInformation: new FormGroup({
      language: new FormControl(''),
      pageNumber: new FormControl(0),
      keywords: new FormControl([])
    }),
    basicInformation: new FormGroup({
      title: new FormControl(''),
      isbn: new FormControl(''),
      description: new FormControl(''),
      authors: new FormControl([]),
      categories: new FormControl([])
    })
  });

  constructor(private authorService: AuthorService, private bookCategoryService: BookCategoryService) {
  }

  ngOnInit () {
    // Initialization for ES Users
    initTE({ Select });
    this.getAllAuthors();
    this.getAllCategories();
  }

  getAllAuthors(): void {
    this.authorService.getAllAuthors()
    .subscribe({
      next: res => this.authors = res as Author[],
      error: err => console.log(err)
    });
  }

  getAllCategories(): void {
    this.bookCategoryService.getAllBookCategories()
    .subscribe({
      next: res => this.bookCategories = res as BookCategory[],
      error: err => console.log(err)
    })
  }

  createBook(): void {
    console.log(this.bookCreateForm.value);
  }
}
