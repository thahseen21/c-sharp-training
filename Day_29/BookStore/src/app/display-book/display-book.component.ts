import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-display-book',
  templateUrl: './display-book.component.html',
  styleUrls: ['./display-book.component.css'],
})
export class DisplayBookComponent implements OnInit {
  constructor() {}

  @Input() bookList: any;

  ngOnInit(): void {
    console.log(this.bookList);
  }
}
