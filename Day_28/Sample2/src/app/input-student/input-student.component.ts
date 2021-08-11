import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-input-student',
  templateUrl: './input-student.component.html',
  styleUrls: ['./input-student.component.css'],
})
export class InputStudentComponent implements OnInit {
  constructor() {}

  @Output() addNewStudentEvent = new EventEmitter();

  ngOnInit(): void {}

  isActive: boolean = false;
  isInActive: boolean = false;

  studentName!: string; // assertion property it will set value as undefined and whenever value is set it should be treated as string the code is equal to studentName: string | undefined;

  // declare studentName: string; //ambient declaration

  onValueChange($event: any) {
    this.studentName = $event.target.value;
  }

  addNewStudent(): void {
    this.addNewStudentEvent.emit({
      name: this.studentName,
      isActive: this.isActive,
    });
  }
  onActiveChange(): void {
    this.isActive = true;
    this.isInActive = false;
  }
  onInActiveChange(): void {
    this.isActive = false;
    this.isInActive = true;
  }
}
