import { Component, OnInit } from '@angular/core'
import { Router } from '@angular/router'
import { UserDetailService } from '../user-detail.service'

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css'],
})
export class PersonalDetailsComponent implements OnInit {
  profileForm: any

  constructor(private router: Router, private userDetail: UserDetailService) {
    this.profileForm = userDetail.profileForm
    console.log(userDetail.profDetailList);
  }

  ngOnInit(): void {}

  goToProfessionalDetails() {
    this.router.navigate(['professionalDetails'])
  }
}
