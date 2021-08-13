import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AddBookComponent } from './add-book/add-book.component';
import { DisplayBookComponent } from './display-book/display-book.component';

@NgModule({
  declarations: [
    AppComponent,
    AddBookComponent,
    DisplayBookComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
