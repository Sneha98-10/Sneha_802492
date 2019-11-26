import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cmentor } from '../models/cmentor';
import { SmentorService } from '../services/smentor.service';

@Component({
  selector: 'app-mentor',
  templateUrl: './mentor.component.html',
  styleUrls: ['./mentor.component.css']
})
export class MentorComponent implements OnInit {
  id:number;
  item:Cmentor;

Mname='';

  constructor(private router : Router,private _service:SmentorService) 
  { this.item = new Cmentor;
    this.id=+localStorage.getItem('token');
    this._service.Search(this.id).subscribe(k=>this.item=k);
    this.Mname=this.item.mname;
    console.log(this.Mname)
}


// Mname='';
// constructor(private router : Router) 
// { this.Mname=localStorage.getItem('token');
// }

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


