import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GoogleAddress } from '../model/address';
import { AuthService } from '../service/auth.service';
import { GoogleaddressService } from '../service/googleaddress.service';

@Component({
  selector: 'app-booking-f',
  templateUrl: './booking-f.component.html',
  styleUrls: ['./booking-f.component.scss']
})
export class BookingFComponent implements OnInit {


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

  constructor(private http : HttpClient,private authService : AuthService,private formBuilder: FormBuilder,private googleAddressService: GoogleaddressService) { }

  locationname="string";
  typelo  ="NAN";
  typeme ='';
  merchname='';

 mercs : any;

  ngOnInit(): void {
    const initialAddress : GoogleAddress =  {
      address: '',   city: '',province:''
    };
    this.googleAddress = initialAddress;
    this.form = this.formBuilder.group(
      {
     
        address: (this.googleAddress.address,['',Validators.required]),
        city: (this.googleAddress.city,[
          '',
          
            Validators.required,
            
          
        ]),
        type:['',Validators.required],
      },
      
    );
  }

  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }

  Searchcity()
  {
    this.submitted = true;

    if (this.form.invalid) {
      return;
    }
  
    console.log(JSON.stringify(this.form.value, null, 2));

    let data = {
       "merchAddress": this.form.value.location,
      
    }
    let data1 = {
      "merchType": this.form.value.area
    }

    this.authService.searchmerchant(this.form.value.city,this.form.value.type).subscribe(
      (res : any) =>{
        console.log("Results :",res);
         this.mercs = res;
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
  
    );
 
  google.maps.event.addListener(autocomplete, 'place_changed', () => {
    this.place = autocomplete.getPlace();
    this.formattedAddress = this.googleAddressService.getFormattedAddress(this.place);
    this.patchGoogleAddress();
    this.showDetails = true;
  });
}


  patchGoogleAddress() {
   
    const test = this.googleAddressService.getFormattedAddress(this.place);
    let googleAddress: GoogleAddress = {
   
      address: `${test == undefined ? '' : test}`,
      city: this.googleAddressService.getLocality(this.place),
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
        this.form.get('city')!.patchValue(address.city);
        this.form.get('province')!.patchValue(address.province);
      }

  }



}
