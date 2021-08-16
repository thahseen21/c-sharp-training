import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'todo-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css'],
})
export class TodoInput {
  @Output() newTodoEvent = new EventEmitter<string>();

  getTodo(value: string) {
    this.newTodoEvent.emit(value);
  }
}
