import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Ctechnology } from '../models/ctechnology';

@Injectable({
  providedIn: 'root'
})
export class StechnologyService {
  path:string='http://localhost:1090/api/Skills';
  constructor(private _client:HttpClient){}
  
  public GetAll():Observable<Ctechnology[]>
  {
    return this._client.get<Ctechnology[]>(this.path+'/GetSkills');
  }
  public Add(item:Ctechnology):Observable<string>{
    return this._client.post<string>(this.path+'/AddSkills',item);
  }
  public Search(id:number):Observable<Ctechnology>{
    return this._client.get<Ctechnology>(this.path+'/GetSkillsById/'+id);
  }
  public Update(item:Ctechnology){
    return this._client.put(this.path+'/UpdateSkills',item);
  }
  public Delete(id:number)
  {
    return this._client.delete(this.path+'/Delete/'+id);
  }
  public Block(id:number)
  {
  return this._client.put(this.path+'/Block/'+id,id);
  }

}