import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-input-form',
  templateUrl: './input-form.component.html',
  styleUrls: ['./input-form.component.css'],
})
export class InputFormComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  userDetail = new FormGroup({
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
    phoneNum: new FormControl('', Validators.required),
    mail: new FormControl('', [Validators.required, Validators.email]),
    address: new FormGroup({
      home: new FormControl('', Validators.required),
      area: new FormControl('', Validators.required),
      state: new FormControl('', Validators.required),
      city: new FormControl('', Validators.required),
    }),
  });

  states = [
    { id: 1, state: 'Kerala' },
    { id: 1, state: 'TamilNadu' },
    { id: 2, state: 'Karnataka' },
    { id: 2, state: 'Andhra Pradesh' },
  ];
  cities = [
    { id: 1, city: 'Ernakulam' },
    { id: 1, city: 'Cochin' },
    { id: 2, city: 'Chennai' },
    { id: 2, city: 'Trichy' },
  ];

  filteredCities: any;

  stateChange($event: any) {
    this.filteredCities = this.cities.filter(
      (item, index) => item.id === parseInt($event.target.value)
    );
  }

  addResponse() {
    console.log(this.userDetail);
  }
}
