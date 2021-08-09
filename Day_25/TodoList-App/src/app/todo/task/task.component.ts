import { Component, Input } from '@angular/core';

@Component({
  selector: 'todo-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
})
export class TodoTask {
  @Input() todoList: any;
}
