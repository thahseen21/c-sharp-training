import { Component, OnInit } from '@angular/core'
import { UserDetailService } from '../user-detail.service'
import { Router } from '@angular/router'

@Component({
  selector: 'app-professional-details',
  templateUrl: './professional-details.component.html',
  styleUrls: ['./professional-details.component.css'],
})
export class ProfessionalDetailsComponent implements OnInit {
  professionalDetails
  constructor(public userDetail: UserDetailService, private router: Router) {
    this.professionalDetails = userDetail.profDetailList
  }

  addNewProfDetail() {
    this.userDetail.addProfDetail()
  }

  goToAttachment() {
    this.router.navigate(['attachmentDetails'])
    console.log(this.professionalDetails)
  }

  ngOnInit(): void {}
}
