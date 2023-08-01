import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { faCommentDots, faBrain, faGlasses, faBook, faChevronRight, faChevronLeft, faHeartCrack } from '@fortawesome/free-solid-svg-icons';
import BookService from 'src/app/services/book.service';
import { BookCopy } from 'src/app/models/book-copy.model';
import { currentMonth } from '../../utils/get-month';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  faCommentDots = faCommentDots;
  faBrain = faBrain;
  faGlasses = faGlasses;
  faHeartCrack = faHeartCrack;
  faBook = faBook;
  faChevronRight = faChevronRight;
  faChevronLeft = faChevronLeft;
  bookCopies: BookCopy[] = [];
  defaultTransform = 0;
  month = currentMonth;

  constructor(private bookService: BookService) {}

  ngOnInit(): void {
    this.bookService.getAllBookCopies()
    .subscribe({
      next: (res) => this.bookCopies = res as BookCopy[],
      error: (err) => console.log(err)
    });
  }
  
  @ViewChild('slider', { static: true }) slider!: ElementRef<HTMLInputElement>;
  goPrev = () => {
    if (Math.abs(this.defaultTransform) === 0) this.defaultTransform = 0;
    else this.defaultTransform = this.defaultTransform + 307;
    if (Math.abs(this.defaultTransform) === 307*3) this.defaultTransform = 0;
    this.slider.nativeElement.style.transform = `translateX(${this.defaultTransform}px)`;
  }

  goNext = () => {
    this.defaultTransform = this.defaultTransform - 307;
    if (Math.abs(this.defaultTransform) === 307*3) this.defaultTransform = -307*2;
    this.slider.nativeElement.style.transform = `translateX(${this.defaultTransform}px)`;
  }
}
