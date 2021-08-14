import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css'],
})
export class AddBookComponent implements OnInit {
  constructor() {}

  @Output() addNewBookEvent = new EventEmitter();

  addNewBook(
    isbn: any,
    title: string,
    description: string,
    author: string,
    price: string,
    imageURL: string
  ) {
    this.addNewBookEvent.emit({
      isbn,
      title,
      description,
      author,
      price,
      imageURL,
    });
    isbn = '';
  }

  ngOnInit(): void {}
}
