import { Component, OnInit } from '@angular/core';
import { Ctraining } from '../models/ctraining';
import { TrainingService } from '../services/training.service';

@Component({
  selector: 'app-admintraining',
  templateUrl: './admintraining.component.html',
  styleUrls: ['./admintraining.component.css']
})
export class AdmintrainingComponent implements OnInit {

  item:Ctraining;
  list:Ctraining[];
  msg:string;
  constructor(private _service:TrainingService) { 
    this.item=new Ctraining();
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
}

