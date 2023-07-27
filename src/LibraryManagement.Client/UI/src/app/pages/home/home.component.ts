import { HttpClient } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { faPhotoFilm, faMugHot, faUserDoctor, faBook, faChevronRight, faChevronLeft } from '@fortawesome/free-solid-svg-icons';
import { faFaceKiss } from '@fortawesome/free-regular-svg-icons';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  faPhotoFilm = faPhotoFilm;
  faMugHot = faMugHot;
  faFaceKiss = faFaceKiss;
  faUserDoctor = faUserDoctor;
  faBook = faBook;
  faChevronRight = faChevronRight;
  faChevronLeft = faChevronLeft;
  books: any;
  defaultTransform = 0;

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
