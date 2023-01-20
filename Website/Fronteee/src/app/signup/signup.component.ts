import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { GoogleAddress } from '../model/address';
import { AuthService } from '../service/auth.service';
import { GoogleaddressService } from '../service/googleaddress.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  showDetails = false;
  @Input() addressType!: string  ;
  place!: object;
  @ViewChild('addresstext') addresstext: any;
  
  establishmentAddress!: Object;

  formattedAddress!: string ;
  formattedEstablishmentAddress!: string;

  addressForm!: FormGroup;
  googleAddress!: GoogleAddress;


  form!: FormGroup;
  submitted = false;
 

  constructor(private formBuilder: FormBuilder,private router: Router,private authService:AuthService,private googleAddressService: GoogleaddressService) { }

  ngOnInit(): void {
    const initialAddress : GoogleAddress =  {
      address: '',   city: '',province:''
    };
    this.googleAddress = initialAddress;
    this.form = this.formBuilder.group(
      {
       
        username: [
          '',
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(20)
          ]
        ],
        Surname: ['', Validators.required],
        email: ['', [Validators.required, Validators.email]],
        contact: ['',[Validators.required,Validators.minLength(10)]],
        address: (this.googleAddress.address,['',Validators.required]),
        city :(this.googleAddress.city, ['',Validators.required]),
        province: (this.googleAddress.province,['',Validators.required]),
        password: [
          '',
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(40)
          ]
        ],
        confirmPassword: ['', 
        [Validators.required,
          Validators.minLength(6),
          Validators.maxLength(40)
        ]

      ]
         
      },
      
    );
  }
  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }
  onSubmit(): void {
   
  }


  reg()
  {
    this.submitted = true;

    if (this.form.invalid) {
      return;
    }

    console.log(JSON.stringify(this.form.value, null, 2));
    let data = {
      
      "userName":this.form.value.username ,
      "userSurname": this.form.value.Surname,
      "userEmail": this.form.value.email,
      "userContactdetails": this.form.value.contact ,
      "userAddress": this.form.value.address ,
      "userPassword": this.form.value.password
     
  }
    this.authService.userRegister(data).subscribe((res : any) => {
      console.log("Results :",res);
   this.router.navigateByUrl('signin');
    }, (error : any) => {
      console.log(error.error);
    }
    )

  }
  ngAfterViewInit() {
    this.getPlaceAutocomplete();
  }


  private getPlaceAutocomplete() {
    const autocomplete = new google.maps.places.Autocomplete(
      this.addresstext.nativeElement,
     // {
        // componentRestrictions: { country: 'ZA' },
       // types: [this.addressType]  // 'establishment' / 'address' / 'geocode' // we are checking all types
     // }
    );
  //  autocomplete.setFields(['place_id', 'name', 'address_components', 'geometry']);
  google.maps.event.addListener(autocomplete, 'place_changed', () => {
    this.place = autocomplete.getPlace();
    this.formattedAddress = this.googleAddressService.getFormattedAddress(this.place);
    this.patchGoogleAddress();
    this.showDetails = true;
  });
}


  patchGoogleAddress() {
   // const streetNo = this.googleAddressService.getStreetNumber(this.place);
    //const street = this.googleAddressService.getStreet(this.place);
    const test = this.googleAddressService.getFormattedAddress(this.place);
    let googleAddress: GoogleAddress = {
     // addressLine1: `${streetNo === undefined ? '' : streetNo} ${street === //undefined ? '' : street
   //     }`,
      address: `${test == undefined ? '' : test}`,
     // addressLine2: `${test == undefined ? '' : test}`,
     // postalCode: this.googleAddressService.getPostCode(this.place),
      city: this.googleAddressService.getLocality(this.place),
     // state: this.googleAddressService.getState(this.place),
     // country: this.googleAddressService.getCountryShort(this.place),
      //district: this.googleAddressService.getState(this.place),
      province: this.googleAddressService.getState(this.place),
    };
    this.form.markAllAsTouched();
    this.patchAddress(googleAddress);
  }

    patchAddress(address: GoogleAddress) {
      if (this.form !== undefined) {
        this.form
          .get('address')!
          .patchValue(address.address);
       // this.addressForm
         // .get('addressLine2')!
       //   .patchValue(address.addressLine2);
       // this.addressForm.get('postalCode')!.patchValue(address.postalCode);
        this.form.get('city')!.patchValue(address.city);
        //this.addressForm.get('state')!.patchValue(address.state);
        //this.addressForm.get('country')!.patchValue(address.country);
        this.form.get('province')!.patchValue(address.province);
      }

  }

}
