import { Component, Input } from '@angular/core';

@Component({
  selector: 'todo-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class TodoHeader {
  @Input() todoList: any;
  totalTask = 0;
  inCompletedTask = 0;

  ngDoCheck(): void {
    //Called every time that the input properties of a component or a directive are checked. Use it to extend change detection by performing a custom check.
    //Add 'implements DoCheck' to the class.
    this.inCompletedTask = 0;
    this.totalTask = 0;
    this.todoList.map((item: any) => {
      if (!item.isOver) {
        this.inCompletedTask++;
      }
      this.totalTask++;
    });
  }
}
