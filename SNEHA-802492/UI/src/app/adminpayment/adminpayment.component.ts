import { Component, OnInit } from '@angular/core';
import { Cpayment } from '../models/cpayment';
import { SpaymentService } from '../services/spayment.service';

@Component({
  selector: 'app-adminpayment',
  templateUrl: './adminpayment.component.html',
  styleUrls: ['./adminpayment.component.css']
})
export class AdminpaymentComponent implements OnInit {

  item:Cpayment;
  list:Cpayment[];
  msg:string;
  constructor(private _service:SpaymentService) { 
    this.item=new Cpayment();
    this._service.GetAll().subscribe(k=>this.list=k)
   
  }

  ngOnInit() {
  }
  // public Delete(Id:number){
  //   this._service.Delete(Id).subscribe(k=>k=this.msg)
  // }
  // public Block(Id:number)
  // {
  //   this._service.Block(Id).subscribe(k=>this.msg);
  // }
}





