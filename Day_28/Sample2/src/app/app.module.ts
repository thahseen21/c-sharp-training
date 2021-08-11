import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DisplayStudentComponent } from './display-student/display-student.component';
import { InputStudentComponent } from './input-student/input-student.component';

@NgModule({
  declarations: [
    AppComponent,
    DisplayStudentComponent,
    InputStudentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
