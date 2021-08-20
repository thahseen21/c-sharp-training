import { Injectable } from '@angular/core'
import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms'

@Injectable({
  providedIn: 'root',
})
export class UserDetailService {
  profDetailList:FormGroup;


  constructor(private fb:FormBuilder) {

  this.profDetailList = this.fb.group({
    professional:new FormArray([this.createProfDetail()])
  })

  }

  get profDetailFormGroup(){
    return this.profDetailList.get('professional') as FormArray;
  }

  createProfDetail(): FormGroup {
    return new FormGroup({
      company:new FormControl(''),
      designation:new FormControl(''),
      startDate: new FormControl(''),
      endDate:new FormControl(''),
      skills: new FormControl(''),
    })
  }

  addProfDetail() {
    this.profDetailFormGroup.push(this.createProfDetail())
  }

  profileForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    phoneNumber: new FormControl(''),
    address: new FormGroup({
      street: new FormControl(''),
      city: new FormControl(''),
      state: new FormControl(''),
      zip: new FormControl(''),
    }),
  })

  attachmentForm = new FormGroup({
    attachment: new FormControl()
  })
}
