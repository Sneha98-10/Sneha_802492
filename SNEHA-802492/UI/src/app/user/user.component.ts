import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SuserService } from '../services/suser.service';
import { Cuser } from '../Models/cuser';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  id:number;
  item:Cuser;

Uname='';

  constructor(private router : Router,private _service:SuserService) 
  { this.item = new Cuser;
    this.id=+localStorage.getItem('token');
    this._service.Search(this.id).subscribe(k=>this.item=k);
    this.Uname=this.item.uname;
    console.log(this.Uname)
}

ngOnInit() {
  if(localStorage.getItem('token')==null)
  {
    this.router.navigate(['userlogin']);
  }


}
logout(){
 localStorage.removeItem('token');
 this.router.navigate(['userlogin']);

 }
}
