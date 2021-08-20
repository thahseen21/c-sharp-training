import { Component, OnInit } from '@angular/core';
import { UserDetailService } from '../user-detail.service';

@Component({
  selector: 'app-attachment-details',
  templateUrl: './attachment-details.component.html',
  styleUrls: ['./attachment-details.component.css'],
})
export class AttachmentDetailsComponent implements OnInit {
  attachmentForm;
  constructor(private userDetail: UserDetailService) {
    this.attachmentForm = userDetail.attachmentForm;
  }

  ngOnInit(): void {}

  submitForm() {
    console.log('submit form',this.attachmentForm);
  }
}
