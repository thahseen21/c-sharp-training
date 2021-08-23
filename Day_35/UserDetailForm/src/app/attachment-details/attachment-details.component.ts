import { Component, OnInit } from '@angular/core';
import { UserDetailService } from '../user-detail.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-attachment-details',
  templateUrl: './attachment-details.component.html',
  styleUrls: ['./attachment-details.component.css'],
})
export class AttachmentDetailsComponent implements OnInit {
  attachmentForm;
  constructor(private userDetail: UserDetailService,private router:Router) {
    this.attachmentForm = userDetail.attachmentForm;
  }

  ngOnInit(): void {}

  submitForm() {
    alert("Form has been successfully submitted")
    this.router.navigate(['profileForm'])
    this.userDetail.userDetailList.push({'personalDetails':this.userDetail.profileForm.value,'professionalDetails':this.userDetail,'resumeDetails':this.userDetail.attachmentForm.value})
    this.userDetail.profileForm.reset();
    this.userDetail.profDetailFormGroup.reset();
    this.userDetail.attachmentForm.reset();
  }
} 
