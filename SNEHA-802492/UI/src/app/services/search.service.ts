import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cmentor } from '../models/cmentor';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  path: String = "http://localhost:5003/api/User"
  constructor(private _client : HttpClient) { }
  public SearchMentor(skills:String): Observable<Cmentor[]>
  {
    return this._client.get<Cmentor[]>(this.path+'/GetMskills/'+skills);
  }
}