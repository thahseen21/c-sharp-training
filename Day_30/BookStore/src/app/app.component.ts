import { Component } from '@angular/core';
import { BookService } from './book.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'BookStore';
  isBookOpen!: boolean;
  isDisplayOpen!: boolean;

  constructor(public bookToggler: BookService) {
    let data = localStorage.getItem('bookList');
    if (data) {
      this.bookList = JSON.parse(data);
    }
    this.isBookOpen = bookToggler.addBook;
    this.isDisplayOpen = bookToggler.displayBook;
  }

  bookList = new Array<{
    isbn: number;
    title: string;
    description: string;
    author: string;
    price: number;
    imageLink: string;
  }>(
    {
      isbn: 1987983724,
      title: 'Pointers in c',
      description: 'a book to explore more in c pointer',
      author: 'Yeshwant',
      price: 299,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
      imageLink:
        'https://images-na.ssl-images-amazon.com/images/I/81XP4ACaZ1L.jpg',
    }
  );

  addNewBook(data: any) {
    this.bookList.push({
      isbn: data.isbn,
      title: data.title,
      description: data.description,
      author: data.author,
      price: data.price,
      imageLink: data.imageURL,
    });
    localStorage.setItem('bookList', JSON.stringify(this.bookList));
  }
  toggleBook() {
    const values: any = this.bookToggler.toggleAddNewBook();
    this.isBookOpen = values.isBookOpen;
    this.isDisplayOpen = values.isDisplayOpen;
  }
  toggleDisplay() {
    const values: any = this.bookToggler.toggleDisplayBook();
    this.isBookOpen = values.isBookOpen;
    this.isDisplayOpen = values.isDisplayOpen;
  }
  closeModal() {
    console.log('closing modal');
    const values: any = this.bookToggler.toggleCloseBackDrop();
    this.isBookOpen = values.isBookOpen;
    this.isDisplayOpen = values.isDisplayOpen;
  }
}
