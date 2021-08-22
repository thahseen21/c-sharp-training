import { Component } from '@angular/core'
import { Router } from '@angular/router'
import { UserDetailService } from './user-detail.service'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'userDetailForm'

  constructor(private router: Router, private userDetail: UserDetailService) {}

  forwardToProfessionalDetails() {
    if (this.userDetail.profileForm.valid) {
      this.router.navigate(['/professionalDetails'])
    } else {
      alert('Please fill this form')
    }
  }
  forwardToAttachmentDetails(){
    if(this.userDetail.profDetailFormGroup.valid){
      this.router.navigate(['/attachmentDetails'])
    }else{
alert('Please fill this form')
    }
  }
}
