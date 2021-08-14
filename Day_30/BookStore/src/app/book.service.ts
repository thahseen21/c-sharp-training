import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  constructor() {}

  addBook: boolean = false;
  displayBook: boolean = false;

  toggleAddNewBook(): object {
    return {
      isBookOpen: (this.addBook = true),
      isDisplayOpen: (this.displayBook = false),
    };
  }
  toggleDisplayBook(): object {
    return {
      isBookOpen: (this.addBook = false),
      isDisplayOpen: (this.displayBook = true),
    };
  }
  toggleCloseBackDrop(): object {
    return {
      isBookOpen: (this.addBook = false),
      isDisplayOpen: (this.displayBook = false),
    };
  }
}
