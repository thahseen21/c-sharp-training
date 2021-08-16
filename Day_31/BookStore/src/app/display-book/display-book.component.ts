import { Component, OnInit } from '@angular/core';
import { BooksService } from '../books.service';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';

@Component({
  selector: 'app-display-book',
  templateUrl: './display-book.component.html',
  styleUrls: ['./display-book.component.css']
})
export class DisplayBookComponent implements OnInit {

  constructor(public books: BooksService,private sanitizer:DomSanitizer,private router:Router) { }

  ngOnInit(): void {
  }

  displayImage(image:any){
    return this.sanitizer.bypassSecurityTrustResourceUrl(`data:image/png;base64, ${image}`);
  }

  showBookDetails(id:any){
    this.router.navigate([`/book/${id}`]);
  }

}
