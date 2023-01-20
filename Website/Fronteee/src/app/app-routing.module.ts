import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { RouterModule, Routes } from '@angular/router';;
import { AboutUsComponent } from './about-us/about-us.component';
import { AddtoserviceComponent } from './addtoservice/addtoservice.component';
import { BookingComponent } from './booking/booking.component';
import { ContactComponent } from './contact/contact.component';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { EditprofileComponent } from './editprofile/editprofile.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { RegisterComponent } from './register/register.component';
import { ReservebookingComponent } from './reservebooking/reservebooking.component';
import { TrackbookingComponent } from './trackbooking/trackbooking.component';
import { TypeofJobsComponent } from './typeof-jobs/typeof-jobs.component';
import { AuthGuard } from './auth/auth.guard';
 


//what i have added

import { SigninComponent } from './signin/signin.component';
import { SignupComponent } from './signup/signup.component';
import { HprofileComponent } from './hprofile/hprofile.component';
import { HbookingComponent } from './hbooking/hbooking.component';
import { MyprofileComponent } from './myprofile/myprofile.component';
import { MercSingleComponent } from './merc-single/merc-single.component';
import { BookreviewComponent } from './bookreview/bookreview.component';
import { TrackbookingbetaComponent } from './trackbookingbeta/trackbookingbeta.component';
import { AuthaaGuard } from './auth/authaa.guard';
import { SingleMerchantComponent } from './single-merchant/single-merchant.component';
import { TestprogressComponent } from './testprogress/testprogress.component';
import { AdminhomeComponent } from './adminhome/adminhome.component';
import { VerifysingleComponent } from './verifysingle/verifysingle.component';
import { VerifymerchantComponent } from './verifymerchant/verifymerchant.component';
import { TesttimeComponent } from './testtime/testtime.component';
import { HomeFComponent } from './home-f/home-f.component';
import { TrackbookingFComponent } from './trackbooking-f/trackbooking-f.component';
import { BookingFComponent } from './booking-f/booking-f.component';
import { AdminhomeFComponent } from './adminhome-f/adminhome-f.component';
import { ReportsFComponent } from './reports-f/reports-f.component';
import { VerifymerchantFComponent } from './verifymerchant-f/verifymerchant-f.component';
import { AboutusFComponent } from './aboutus-f/aboutus-f.component';
import { ContactFComponent } from './contact-f/contact-f.component';
import { PortfolioFComponent } from './portfolio-f/portfolio-f.component';
import { DatepickerFComponent } from './datepicker-f/datepicker-f.component';
import { UploadfileComponent } from './uploadfile/uploadfile.component';
import { UploadComponent } from './upload/upload.component';
import { RatetestComponent } from './ratetest/ratetest.component';
import { BookreserveComponent } from './bookreserve/bookreserve.component';
import { AcceptedrequestComponent } from './acceptedrequest/acceptedrequest.component';
import { BookingrequestComponent } from './bookingrequest/bookingrequest.component';
import { CompletedbookingComponent } from './completedbooking/completedbooking.component';
import { ServicebycategoryComponent } from './servicebycategory/servicebycategory.component';
import { RatingComponent } from './rating/rating.component';
import { HomelogComponent } from './homelog/homelog.component';

const routes: Routes = [
{
  path: 'login',
  component: LoginComponent 
},
{
  path: 'register',
  component: RegisterComponent,
  canActivate:[AuthaaGuard]
},
{
  path: 'home',
  component: HomeComponent,
  canActivate:[AuthGuard]
},
{
  path: 'contact',
  component: ContactComponent
},
{
  path: 'booking',
  component: BookingComponent
},
{
  path: 'datepicker',
  component: DatePickerComponent
},
{
  path: 'addtoservice',
  component: AddtoserviceComponent
},
{
  path: 'about',
  component: AboutUsComponent
},
{
  path: 'editprofile',
  component: EditprofileComponent
},
{
  path: 'tracking',
  component: TrackbookingComponent
},
{
  path: 'typeofjobs',
  component: TypeofJobsComponent
},
{
  path: 'profile',
  component: ProfileComponent
},
{
  path: 'reservebooking',
  component: ReservebookingComponent
},
{ path: 'signin', component:SigninComponent},
{path: 'signup', component:SignupComponent},
{path: 'hprofile', component:HprofileComponent},
{path : 'hprofile/editp/:id',component:MyprofileComponent},
{path: 'hbooking',component:HbookingComponent},
{path : 'hbooking/singlemerchant/:id/bookreview/:id',component:BookreviewComponent},
{path : 'hbooking/single/:id', component:MercSingleComponent},
{path: 'bbooking',component:TrackbookingbetaComponent},
{path: 'hbooking/singlemerchant/:id', component:SingleMerchantComponent},

{path:'test', component:TestprogressComponent},

{path:'admin',component:AdminhomeComponent},
{path:'vmerchant/vsingle/:id',component:VerifysingleComponent},
{path:'vmerchant',component:VerifymerchantComponent},
{path:'time',component:TesttimeComponent},

// frenkie staff start from here 
{path:'homef',component:HomeFComponent},
{path:'trackingf',component:TrackbookingFComponent},
{path:'bookingf',component:BookingFComponent},
{path:'adminf',component:AdminhomeFComponent},
{path:'reportsf',component:ReportsFComponent},
{path:'verifyf',component:VerifymerchantFComponent},
{path:'aboutf',component:AboutusFComponent},
{path:'contactf',component:ContactFComponent},
{path:'portof',component:PortfolioFComponent},
{path:'hbooking/singlemerchant/:id/datepickerf/:id',component:DatepickerFComponent},

{path:'upload',component:UploadfileComponent},
{path:'jena',component:UploadComponent},
{path:'rate',component:RatetestComponent},
{path:'hbooking/singlemerchant/:id/bookreserve/:id',component:BookreserveComponent},
{path:'homelog',component:HomelogComponent},
{
  path: 'arequest',
  component: AcceptedrequestComponent
},
{
  path: 'brequest',
  component: BookingrequestComponent
},
{
  path: 'cbooking',
  component: CompletedbookingComponent
},
{
  path: 'serviceby',
  component: ServicebycategoryComponent
},
{
  path: 'rating',
  component: RatingComponent
},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
