import { Component } from '@angular/core';
import { faCopy, faHouseCircleCheck, faUserCheck } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  faCopy = faCopy;
  faHouseCircleCheck = faHouseCircleCheck;
  faUserCheck = faUserCheck;
}
