import { Component, OnInit } from '@angular/core'
import { UserDetailService } from '../user-detail.service'
import { Router } from '@angular/router'
import { FormGroup } from '@angular/forms'

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

  removeProfileDetail(index:number){
    this.userDetail.removeProfDetail(index);
  }

  goToAttachment() {
    this.router.navigate(['attachmentDetails'])
  }

  getFormControl(id: number, controlName: string) {
    return this.professionalDetails
      .get(`professional.${id}`)
      ?.get(controlName) as FormGroup
  }

  ngOnInit(): void {}
}
