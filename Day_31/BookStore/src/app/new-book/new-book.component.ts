import { Component, OnInit } from '@angular/core';
import { BooksService } from '../books.service';
import { DomSanitizer } from '@angular/platform-browser';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-book',
  templateUrl: './new-book.component.html',
  styleUrls: ['./new-book.component.css'],
})
export class NewBookComponent implements OnInit {
  constructor(private book: BooksService, private sanitizer: DomSanitizer) {}

  ngOnInit(): void {
    console.log(this.bookForm);
  }

  bookForm = new FormGroup({
    isbn: new FormControl('', [
      Validators.min(1000000000),
      Validators.required,
    ]),
    title: new FormControl('', Validators.required),
    description: new FormControl('', Validators.required),
    author: new FormControl('', Validators.required),
    price: new FormControl('', Validators.required),
  });

  image!: string;

  addNewBook() {
    if (this.bookForm.status === 'VALID') {
      this.book.AddBook(this.bookForm.value, this.image);
      this.bookForm.reset();
    }
  }
  onFileChanged(data: any) {
    console.log(data.target.files[0]);
    const reader = new FileReader();
    reader.readAsDataURL(data.target.files[0]);
    var base64String, base64Image;
    reader.onload = () => {
      base64String = reader.result;
      var base64Image = base64String?.toString().split(';base64,').pop();
      // console.log(base64Image)
      if (base64Image) {
        this.image = base64Image;
      }
    };
    //  console.log(this.sanitizer.bypassSecurityTrustResourceUrl(`data:image/png;base64, ${base64Image}`)) ;
  }
}
