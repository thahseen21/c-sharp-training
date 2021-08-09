import { Component } from '@angular/core';

@Component({
  selector: 'todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css'],
})
export class TodoComponent {
  todoList = [{ todo: 'potato', isOver: false }];

  newTodo = '';

  receiveNewTodo($event: string) {
    console.log('in todo component', $event);
    this.newTodo = $event;
  }
}
