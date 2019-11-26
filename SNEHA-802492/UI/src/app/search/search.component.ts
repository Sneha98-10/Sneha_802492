import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchService } from '../services/search.service';
import { Cmentor } from '../models/cmentor';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  item:Cmentor;
  list:Cmentor[];
  skills:string;
 

  constructor(private _service : SearchService, private http: HttpClient) {
    
   }
 
  ngOnInit() {
  }
  public Search()
  {
    this._service.SearchMentor(this.skills).subscribe(k=>{this.list=k;
      console.log(k)});

}
}



