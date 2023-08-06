import { Component, OnInit } from '@angular/core';
import { faBookOpen, faHouse, faFeatherPointed, faChevronDown, faUserPen, faDoorOpen, faUsersLine } from '@fortawesome/free-solid-svg-icons';
import { faCopy } from '@fortawesome/free-regular-svg-icons';
import {
  Collapse,
  initTE,
} from "tw-elements";

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
})
export class SideBarComponent implements OnInit {
  faBookOpen = faBookOpen;
  faHouse = faHouse;
  faFeatherPointed = faFeatherPointed;
  faChevronDown = faChevronDown;
  faCopy = faCopy;
  faUserPen = faUserPen;
  faUsersLine = faUsersLine;
  faDoorOpen = faDoorOpen;

  ngOnInit () {
    // Initialization for ES Users


initTE({ Collapse });
  }
}