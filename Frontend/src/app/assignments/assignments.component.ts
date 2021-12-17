import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-assignments',
  templateUrl: './assignments.component.html',
  styleUrls: ['./assignments.component.css']
})
export class AssignmentsComponent implements OnInit {

  constructor(private service:SharedService) { }

  AssignmentList:any=[];
  ngOnInit(): void {
  }

  refreshAssignmentList(){
    
  }

}
