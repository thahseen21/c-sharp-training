import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { BooksService } from '../books.service';
import Book from '../models/book';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.css'],
})
export class BookDetailsComponent implements OnInit {
  constructor(
    private sanitizer: DomSanitizer,
    private router: Router,
    private bookService: BooksService
  ) {}

  book!: Book;

  ngOnInit(): void {
    console.log('potato');
    this.book =
      this.bookService.bookList[parseInt(this.router.url.split('/')[2])];
  }

  displayImage(image: any) {
    return this.sanitizer.bypassSecurityTrustResourceUrl(
      `data:image/png;base64, ${image}`
    );
  }
}
