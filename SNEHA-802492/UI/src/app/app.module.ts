import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { MentorComponent } from './mentor/mentor.component';
import { AdminComponent } from './admin/admin.component';
import { LoginComponent } from './login/login.component';
import { LoginModule } from './login/login.module';
import { SignupComponent } from './signup/signup.component';
import { SignupModule } from './signup/signup.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AdminsignupComponent } from './signup/adminsignup/adminsignup.component';
import { MentorsignupComponent } from './signup/mentorsignup/mentorsignup.component';
import { UsersignupComponent } from './signup/usersignup/usersignup.component';
import { EmailValidatorDirective } from './email-validator.directive';
import { PasswordValidatorDirective } from './password-validator.directive';
import { SuserService } from './services/suser.service';
import { SmentorService } from './services/smentor.service';

import { AdminuserComponent } from './adminuser/adminuser.component';
import { AdminmentorComponent } from './adminmentor/adminmentor.component';
import { AdmintechnologyComponent } from './admintechnology/admintechnology.component';
import { AdmintrainingComponent } from './admintraining/admintraining.component';
import { AdminpaymentComponent } from './adminpayment/adminpayment.component';
import { AdmindashboardComponent } from './admindashboard/admindashboard.component';
import { SearchComponent } from './search/search.component';
import { UnotificationsComponent } from './unotifications/unotifications.component';
import { UcurrentComponent } from './ucurrent/ucurrent.component';
import { UcompletedComponent } from './ucompleted/ucompleted.component';
import { MnotificationsComponent } from './mnotifications/mnotifications.component';
import { McurrentComponent } from './mcurrent/mcurrent.component';
import { McompletedComponent } from './mcompleted/mcompleted.component';




@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    AdmindashboardComponent,
    AdminuserComponent,
    AdminmentorComponent,
    AdmintechnologyComponent,
    AdmintrainingComponent,
    AdminpaymentComponent,
    MentorComponent,
    AdminComponent,
    LoginComponent,
    SignupComponent,
    EmailValidatorDirective,
    PasswordValidatorDirective,
    SearchComponent,
    UnotificationsComponent,
    UcurrentComponent,
    UcompletedComponent,
    MnotificationsComponent,
    McurrentComponent,
    McompletedComponent,
    
    // UsersignupComponent,
    // MentorsignupComponent,
    //AdminsignupComponent
  ],
  imports: [
    BrowserModule,
    LoginModule,
    SignupModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule

  ],
  providers: [SuserService,SmentorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
  