import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  books = [
    {
      title: "To Kill a Mockingbird",
      author: "Harper Lee",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "1984",
      author: "George Orwell",
      img: "../../../assets/product-2.jpg"
    },
    {
      title: "Pride and Prejudice",
      author: "Jane Austen",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "The Great Gatsby",
      author: "F. Scott Fitzgerald",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "The Catcher in the Rye",
      author: "J.D. Salinger",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "To Kill a Mockingbird",
      author: "Harper Lee",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "1984",
      author: "George Orwell",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "Pride and Prejudice",
      author: "Jane Austen",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "The Great Gatsby",
      author: "F. Scott Fitzgerald",
      img: "../../../assets/product-1.jpg"
    },
    {
      title: "The Catcher in the Rye",
      author: "J.D. Salinger",
      img: "../../../assets/product-1.jpg"
    }
  ]
}
