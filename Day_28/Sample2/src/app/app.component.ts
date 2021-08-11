import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Sample2';

  studentList = Array<{ name: string; isActive: boolean }>(
    { name: 'potato', isActive: false },
    { name: 'pineapple', isActive: false }
  );

  header = 'Student DB';

  addNewStudent(data: any) {
    if (data.name.length > 0) {
      this.studentList.push({ name: data.name, isActive: data.isActive });
    }
  }
}
