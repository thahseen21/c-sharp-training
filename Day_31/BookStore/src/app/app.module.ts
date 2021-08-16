import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewBookComponent } from './new-book/new-book.component';
import { DisplayBookComponent } from './display-book/display-book.component';
import { BookDetailsComponent } from './book-details/book-details.component';
import { HeaderComponent } from './header/header.component';

const appRoutes: Routes = [
  { path: 'newbook', component: NewBookComponent },
  { path: 'book', component: DisplayBookComponent },
  { path: 'book/:id', component: BookDetailsComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    NewBookComponent,
    DisplayBookComponent,
    BookDetailsComponent,
    HeaderComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, RouterModule.forRoot(appRoutes), ReactiveFormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
