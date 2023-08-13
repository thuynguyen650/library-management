import { Component, OnInit } from '@angular/core';
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

  ngOnInit () {
    // Initialization for ES Users
    initTE({ Select });
  }
}
