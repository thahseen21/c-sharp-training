import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service';

@Component({
  selector: 'app-backdrop',
  templateUrl: './backdrop.component.html',
  styleUrls: ['./backdrop.component.css'],
})
export class BackdropComponent implements OnInit {
  constructor(public bookToggler: BookService) {}

  // closeModal() {
  //   this.bookToggler.toggleCloseBackDrop();
  // }

  ngOnInit(): void {}
}
