import { Component, OnInit } from '@angular/core';
import { Cmentor } from '../models/cmentor';
import { SmentorService } from '../services/smentor.service';

@Component({
  selector: 'app-adminmentor',
  templateUrl: './adminmentor.component.html',
  styleUrls: ['./adminmentor.component.css']
})
export class AdminmentorComponent implements OnInit {

 
 
  item:Cmentor;
  list:Cmentor[];
  msg:string;
  constructor(private _service:SmentorService) { 
    this.item=new Cmentor();
    this._service.GetAll().subscribe(k=>this.list=k)
   
  }

  ngOnInit() {
  }
  public Delete(Id:number){
    this._service.Delete(Id).subscribe(k=>k=this.msg)
  }
  public Block(Id:number)
  {
    this._service.Block(Id).subscribe(k=>this.msg);
  }
  public UnBlock(Id:number)
  {
    this._service.UnBlock(Id).subscribe(k=>this.msg);
  }
}

