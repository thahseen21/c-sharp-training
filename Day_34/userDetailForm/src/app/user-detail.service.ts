import { Injectable } from '@angular/core'
import {
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms'

@Injectable({
  providedIn: 'root',
})
export class UserDetailService {

  userDetailList:any;

  profDetailList: FormGroup

  constructor(private fb: FormBuilder) {
    this.profDetailList = this.fb.group({
      professional: new FormArray([this.createProfDetail()]),
    })
  }

  get profDetailFormGroup() {
    return this.profDetailList.get('professional') as FormArray
  }

  createProfDetail(): FormGroup {
    return new FormGroup({
      company: new FormControl('', Validators.required),
      designation: new FormControl('', Validators.required),
      startDate: new FormControl('', Validators.required),
      endDate: new FormControl('', Validators.required),
      skills: new FormControl('', Validators.required),
    })
  }

  addProfDetail() {
    this.profDetailFormGroup.push(this.createProfDetail())
  }

  removeProfDetail(index: number) {
    this.profDetailFormGroup.removeAt(index)
  }

  profileForm = new FormGroup({
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
    phoneNumber: new FormControl('', [
      Validators.required,
      Validators.pattern('^[0-9]{10,10}$'),
    ]),
    address: new FormGroup({
      street: new FormControl('', Validators.required),
      city: new FormControl('', Validators.required),
      state: new FormControl('', Validators.required),
      zip: new FormControl('', [
        Validators.required,
        Validators.pattern('^[0-9]{6,6}$'),
      ]),
    }),
  })

  attachmentForm = new FormGroup({
    attachment: new FormControl('',Validators.required),
  })
}
