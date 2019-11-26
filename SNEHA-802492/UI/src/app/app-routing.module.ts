import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MentorComponent } from './mentor/mentor.component';
import { AdminComponent } from './admin/admin.component';
import { UserComponent } from './user/user.component';
import { SignupComponent } from './signup/signup.component';
import { UserloginComponent } from './login/userlogin/userlogin.component';
import { MentorloginComponent } from './login/mentorlogin/mentorlogin.component';
import { MentorsignupComponent } from './signup/mentorsignup/mentorsignup.component';
import { UsersignupComponent } from './signup/usersignup/usersignup.component';
import { AdminsignupComponent } from './signup/adminsignup/adminsignup.component';

import { AdminuserComponent } from './adminuser/adminuser.component';
import { AdminpaymentComponent } from './adminpayment/adminpayment.component';
import { AdmintrainingComponent } from './admintraining/admintraining.component';
import { AdminmentorComponent } from './adminmentor/adminmentor.component';
import { AdmintechnologyComponent } from './admintechnology/admintechnology.component';
import { AdmindashboardComponent } from './admindashboard/admindashboard.component';
import { SearchComponent } from './search/search.component';
import { AppComponent } from './app.component';
import { UnotificationsComponent } from './unotifications/unotifications.component';
import { UcurrentComponent } from './ucurrent/ucurrent.component';
import { UcompletedComponent } from './ucompleted/ucompleted.component';
import { MnotificationsComponent } from './mnotifications/mnotifications.component';
import { McurrentComponent } from './mcurrent/mcurrent.component';
import { McompletedComponent } from './mcompleted/mcompleted.component';



const routes: Routes = [

 
  {path: 'admin',component: AdminComponent},
  
  {path: 'login', component: LoginComponent},
  {path: 'signup',component: SignupComponent},
  {path: 'userlogin',component: UserloginComponent},
  {path: 'mentorlogin',component: MentorloginComponent},
  {path: 'usersignup',component: UsersignupComponent},
  {path: 'mentorsignup',component: MentorsignupComponent},
  {path: 'adminsignup',component: AdminsignupComponent},
  {path: 'admindashboard', component: AdmindashboardComponent,children:[
  {path: 'adminuser', component: AdminuserComponent},
  {path: 'adminmentor', component: AdminmentorComponent},
  {path: 'admintechnology', component: AdmintechnologyComponent},
  {path: 'admintraining', component: AdmintrainingComponent},
  {path: 'adminpayment', component: AdminpaymentComponent}]},
  {path: 'user',component: UserComponent},
 {path: 'unotifications', component: UnotificationsComponent},

  {path: 'ucurrent', component: UcurrentComponent},
  {path: 'ucompleted', component: UcompletedComponent},
  {path: 'mentor',component: MentorComponent},
 {path: 'mnotifications', component: MnotificationsComponent},
  {path: 'mcurrent', component: McurrentComponent},
  {path: 'mcompleted', component: McompletedComponent},
 
   {path:'search',component:SearchComponent}
  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
