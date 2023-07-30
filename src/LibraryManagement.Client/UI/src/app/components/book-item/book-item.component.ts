import { Component, Input } from '@angular/core';
import { faHeart
 } from '@fortawesome/free-regular-svg-icons';
import { BookCopy } from 'src/app/models/book-copy.model';
@Component({
  selector: 'app-book-item',
  templateUrl: './book-item.component.html',
  styleUrls: ['./book-item.component.scss']
})
export class BookItemComponent {
  faHeart = faHeart;
  
  @Input() bookCopy: BookCopy = new BookCopy;
}
