import { Component, OnInit } from '@angular/core';
import { Ctechnology } from '../models/ctechnology';
import { StechnologyService } from '../services/stechnology.service';

@Component({
  selector: 'app-admintechnology',
  templateUrl: './admintechnology.component.html',
  styleUrls: ['./admintechnology.component.css']
})
export class AdmintechnologyComponent implements OnInit {

  item:Ctechnology;
  list:Ctechnology[];
  msg:string;
  addClick;
  constructor(private _service:StechnologyService) { 
    this.item=new Ctechnology();
    this._service.GetAll().subscribe(k=>this.list=k)
    this.addClick=0;
   
  }

  ngOnInit() {
  }
  public Delete(Id:number){
    this._service.Delete(Id).subscribe(k=>k=this.msg)
  }
  public add()
  {
    this.addClick=1;
  }
  public Add()
  {
    this._service.Add(this.item).subscribe(k=>this.msg=k)
  }
  // public Block(Id:number)
  // {
  //   this._service.Block(Id).subscribe(k=>this.msg);
  // }
}


