import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'
import { RouterModule, Routes } from '@angular/router'
import { ReactiveFormsModule } from '@angular/forms'

import { AppRoutingModule } from './app-routing.module'
import { AppComponent } from './app.component'
import { PersonalDetailsComponent } from './personal-details/personal-details.component'
import { ProfessionalDetailsComponent } from './professional-details/professional-details.component'
import { AttachmentDetailsComponent } from './attachment-details/attachment-details.component'

const appRoutes: Routes = [
  {path:'',redirectTo:'profileForm', pathMatch: 'full' },
  { path: 'profileForm', component: PersonalDetailsComponent },
  { path: 'professionalDetails', component: ProfessionalDetailsComponent },
  { path: 'attachmentDetails', component: AttachmentDetailsComponent },
]

@NgModule({
  declarations: [
    AppComponent,
    PersonalDetailsComponent,
    ProfessionalDetailsComponent,
    AttachmentDetailsComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, RouterModule.forRoot(appRoutes),ReactiveFormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
