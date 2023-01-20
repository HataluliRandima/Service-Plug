import { NgModule,CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
//import { BrowserModule } from '@angular/platform-browser';

import { 
	IgxTimePickerModule,
	IgxToastModule
 } from "igniteui-angular";
 
 import { NgxStarRatingModule } from 'ngx-star-rating';

import {MatDatepickerModule} from '@angular/material/datepicker';
 

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

 
import { MatNativeDateModule } from '@angular/material/core';

import { CommonModule } from '@angular/common';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDialogModule } from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { JwtModule } from '@avatsaev/angular-jwt';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TrackbookingComponent } from './trackbooking/trackbooking.component';
import { TypeofJobsComponent } from './typeof-jobs/typeof-jobs.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { AddtoserviceComponent } from './addtoservice/addtoservice.component';
import { BookingComponent } from './booking/booking.component';
import { ContactComponent } from './contact/contact.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ReservebookingComponent } from './reservebooking/reservebooking.component';
import { ProfileComponent } from './profile/profile.component';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { EditprofileComponent } from './editprofile/editprofile.component';
import { HeaderComponent } from './header/header.component';
import { SigninComponent } from './signin/signin.component';
import { SignupComponent } from './signup/signup.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
 import { HprofileComponent } from './hprofile/hprofile.component';
import { MyprofileComponent } from './myprofile/myprofile.component';
import { HbookingComponent } from './hbooking/hbooking.component';
import { MercSingleComponent } from './merc-single/merc-single.component';
import { BookreviewComponent } from './bookreview/bookreview.component';
import { NgToastModule } from 'ng-angular-popup';
import { FooterComponent } from './footer/footer.component';
import { TrackbookingbetaComponent } from './trackbookingbeta/trackbookingbeta.component';
import { SingleMerchantComponent } from './single-merchant/single-merchant.component';
import { TestprogressComponent } from './testprogress/testprogress.component';
import { AdminhomeComponent } from './adminhome/adminhome.component';
import { VerifymerchantComponent } from './verifymerchant/verifymerchant.component';
import { VerifysingleComponent } from './verifysingle/verifysingle.component';
import { TesttimeComponent } from './testtime/testtime.component';
import { HeaderFComponent } from './header-f/header-f.component';
import { FooterFComponent } from './footer-f/footer-f.component';
import { AdminhomeFComponent } from './adminhome-f/adminhome-f.component';
//import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AboutusFComponent } from './aboutus-f/aboutus-f.component';
import { BookingFComponent } from './booking-f/booking-f.component';
import { ContactFComponent } from './contact-f/contact-f.component';
import { DatepickerFComponent } from './datepicker-f/datepicker-f.component';
import { HomeFComponent } from './home-f/home-f.component';
import { PortfolioFComponent } from './portfolio-f/portfolio-f.component';
import { ReportsFComponent } from './reports-f/reports-f.component';
import { TrackbookingFComponent } from './trackbooking-f/trackbooking-f.component';
import { VerifymerchantFComponent } from './verifymerchant-f/verifymerchant-f.component';
import { UploadfileComponent } from './uploadfile/uploadfile.component';
import { AuthInterceptor } from './helper/auth.interceptor';
import { UploadComponent } from './upload/upload.component';
import { RatetestComponent } from './ratetest/ratetest.component';
import { BookreserveComponent } from './bookreserve/bookreserve.component';
import { AcceptedrequestComponent } from './acceptedrequest/acceptedrequest.component';
import { BookingrequestComponent } from './bookingrequest/bookingrequest.component';
import { CompletedbookingComponent } from './completedbooking/completedbooking.component';
import { RatingComponent } from './rating/rating.component';
import { ReportsadminComponent } from './reportsadmin/reportsadmin.component';
import { ServicebycategoryComponent } from './servicebycategory/servicebycategory.component';
import { HomelogComponent } from './homelog/homelog.component';

export function tokenGetter()
{
  return localStorage.getItem("jwt");
}




@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TrackbookingComponent,
    TypeofJobsComponent,
    AboutUsComponent,
    AddtoserviceComponent,
    BookingComponent,
    ContactComponent,
    LoginComponent,
    RegisterComponent,
    ReservebookingComponent,
    ProfileComponent,
    DatePickerComponent,
    EditprofileComponent,
    HeaderComponent,
    SigninComponent,
    SignupComponent,
    HprofileComponent,
    MyprofileComponent,
    HbookingComponent,
    MercSingleComponent,
    BookreviewComponent,
    FooterComponent,
    TrackbookingbetaComponent,
    SingleMerchantComponent,
    TestprogressComponent,
    AdminhomeComponent,
    VerifymerchantComponent,
    VerifysingleComponent,
    TesttimeComponent,
    HeaderFComponent,
    FooterFComponent,
    AdminhomeFComponent,
    AboutusFComponent,
    BookingFComponent,
    ContactFComponent,
    DatepickerFComponent,
    HomeFComponent,
    PortfolioFComponent,
    ReportsFComponent,
    TrackbookingFComponent,
    VerifymerchantFComponent,
    UploadfileComponent,
    UploadComponent,
    RatetestComponent,
    BookreserveComponent,
    AcceptedrequestComponent,
    BookingrequestComponent,
    CompletedbookingComponent,
    RatingComponent,
    ReportsadminComponent,
    ServicebycategoryComponent,
    HomelogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatFormFieldModule,
    NgToastModule,
    MatInputModule,
    ReactiveFormsModule,
    MatDialogModule,
    HttpClientModule,
    CommonModule,
    FormsModule,
    MatNativeDateModule,
    MatDatepickerModule,
    IgxTimePickerModule,
    FontAwesomeModule,
    NgxStarRatingModule,
	IgxToastModule,
    JwtModule.forRoot({
      config:  {
      tokenGetter: tokenGetter,
      whitelistedDomains: ["frenkie-001-site1.ctempurl.com"],
      blacklistedRoutes: [""]
      
      //localhost:7271
      //frenkie-001-site1.ctempurl.com
      }
    })
  ],
  providers: [
    {
      provide : HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi : true
    }
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
