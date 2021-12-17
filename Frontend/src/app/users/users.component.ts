import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  constructor(private service:SharedService) { }
  UserList:any=[];
  ModalTitle:string;
  ActivateEditUserComponent:boolean=false;
  user:any;
  ngOnInit(): void {
    this.refreshUsersList();
  }

  addClick(){

  }

  refreshUsersList(){
    this.service.getAllUsers().subscribe(data=>{
      this.UserList=data;
      console.log(this.UserList);

    })
  }

}
