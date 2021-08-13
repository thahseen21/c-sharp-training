import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'BookStore';

  constructor() {
    let data = localStorage.getItem('bookList');
    if (data) {
      this.bookList = JSON.parse(data);
    }
  }

  bookList = new Array<{
    isbn: number;
    title: string;
    description: string;
    author: string;
    price: number;
  }>(
    {
      isbn: 1987983724,
      title: 'Pointers in c',
      description: 'a book to explore more in c pointer',
      author: 'Yeshwant',
      price: 299,
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
    },
    {
      isbn: 9047923472,
      title: 'Programming in C',
      description: 'a book to explore more in c programs',
      author: 'Sumitha Arora',
      price: 599,
    }
  );

  addNewBook(data: any) {
    this.bookList.push({
      isbn: data.isbn,
      title: data.title,
      description: data.description,
      author: data.author,
      price: data.price,
    });
    localStorage.setItem('bookList', JSON.stringify(this.bookList));
  }
}
