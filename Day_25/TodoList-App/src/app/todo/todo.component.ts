import { Component } from '@angular/core';

@Component({
  selector: 'todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css'],
})
export class TodoComponent {
  todoList = [
    { todo: 'potato', isOver: false, key: 1 },
    { todo: 'another potato', isOver: true, key: 2 },
  ];

  newTodo = '';
  key = 2;

  receiveNewTodo($event: string) {
    console.log('in todo component', $event);
    this.newTodo = $event;
    if (this.newTodo.length > 0) {
      this.todoList.push({
        todo: this.newTodo,
        isOver: false,
        key: ++this.key,
      });
      this.newTodo = '';
    }
  }
}
