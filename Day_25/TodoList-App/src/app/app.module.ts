import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TodoHeader } from './todo/header/header.component';
import { TodoInput } from './todo/input/input.component';
import { TodoTask } from './todo/task/task.component';
import { TodoComponent } from './todo/todo.component';

@NgModule({
  declarations: [AppComponent, TodoComponent, TodoHeader, TodoInput, TodoTask],
  imports: [BrowserModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
