import { Component } from '@angular/core';
import { faHeart, faUser } from '@fortawesome/free-regular-svg-icons';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  faHeart = faHeart;
  faUser = faUser;
}
