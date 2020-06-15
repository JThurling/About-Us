import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {IUser} from '../shared/model/user';

@Injectable({
  providedIn: 'root'
})
export class AboutUsService {
  baseUrl = 'http://localhost:5000/api/';

  constructor(private httpClient: HttpClient) { }

  getUsers(){
    return this.httpClient.get<IUser[]>(this.baseUrl + 'user/');
  }
}
