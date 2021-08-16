import { Injectable } from '@angular/core';
import Book from './models/book';

@Injectable({
  providedIn: 'root',
})
export class BooksService {
  constructor() {}

  bookList = new Array<Book>();

  AddBook(data: any, image: any) {
    this.bookList.push({
      isbn: data.isbn,
      title: data.title,
      description: data.description,
      author: data.author,
      image: image,
      price: data.price,
    });
    localStorage.setItem('bookList',JSON.stringify(this.bookList))
  }
}
