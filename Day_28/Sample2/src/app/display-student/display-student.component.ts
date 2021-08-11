import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-display-student',
  templateUrl: './display-student.component.html',
  styleUrls: ['./display-student.component.css'],
})
export class DisplayStudentComponent {
  constructor() {}

  @Input() studentList: any;

  showStudent: boolean = false;

  displayStudent(): void {
    this.showStudent = !this.showStudent;
  }

  ToggleIsActive(index: number): void {
    this.studentList[index].isActive = !this.studentList[index].isActive;
  }
}
