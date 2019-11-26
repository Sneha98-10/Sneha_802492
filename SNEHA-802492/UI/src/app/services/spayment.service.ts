import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cpayment } from '../models/cpayment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SpaymentService {
  path:string='http://localhost:1095/api/Payment';
  constructor(private _client:HttpClient){}
  
  public GetAll():Observable<Cpayment[]>
  {
    return this._client.get<Cpayment[]>(this.path+'/GetPayment');
  }
  public Add(item:Cpayment):Observable<string>{
    return this._client.post<string>(this.path+'/AddPayment',item);
  }
  // public Search(id:number):Observable<Cpayment>{
  //   return this._client.get<Cpayment>(this.path+'/GetPaymentById/'+id);
  // }
  // public Update(item:Cpayment){
  //   return this._client.put(this.path+'/UpdateUser',item);
  // }
  // public Delete(id:number)
  // {
  //   return this._client.delete(this.path+'/DeleteUser/'+id);
  // }
  // public Block(id:number)
  // {
  // return this._client.put(this.path+'/Block/'+id,id);
  // }

}
