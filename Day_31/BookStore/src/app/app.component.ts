import { Component,OnInit } from '@angular/core';
import { BooksService } from './books.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'BookStore';

  constructor(private books:BooksService){}

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    let data = localStorage.getItem('bookList');
    if(data){
      this.books.bookList = JSON.parse(data);
    }
  }

}
