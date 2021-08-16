import { formatPercent } from '@angular/common';
import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'todo-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
})
export class TodoTask {
  @Input() todoList: any;

  taskCompleteToggler(key: number) {
    for (let todo of this.todoList) {
      if (todo.key === key) {
        todo.isOver = !todo.isOver;
      }
    }
  }

  removeTask(key: number) {
    this.todoList.map((todo: any, index: number) => {
      if (todo.key === key) {
        this.todoList.splice(index, 1);
        localStorage.setItem('todoList', JSON.stringify(this.todoList));
      }
    });
  }
}
