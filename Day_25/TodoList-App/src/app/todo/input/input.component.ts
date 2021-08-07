import { Component } from '@angular/core';

@Component({
  selector: 'todo-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css'],
})
export class TodoInput {
  getTodo(value: string) {
    console.log(value);
  }
}
