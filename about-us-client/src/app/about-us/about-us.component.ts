import { Component, OnInit } from '@angular/core';
import {AboutUsService} from './about-us.service';
import {IUser} from '../shared/model/user';

@Component({
  selector: 'app-about-us',
  templateUrl: './about-us.component.html',
  styleUrls: ['./about-us.component.scss']
})
export class AboutUsComponent implements OnInit {
  users: IUser[];

  constructor(private aboutUsService: AboutUsService) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers(){
    this.aboutUsService.getUsers().subscribe(res => {
      this.users = res;
    }, error => {
      console.log(error);
    });
  }
}
