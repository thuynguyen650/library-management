import { Component } from '@angular/core';
import { faHeart
 } from '@fortawesome/free-regular-svg-icons';
@Component({
  selector: 'app-book-item',
  templateUrl: './book-item.component.html',
  styleUrls: ['./book-item.component.scss']
})
export class BookItemComponent {
  faHeart = faHeart;

  add = () => {
    console.log("aaa");
  }
}
