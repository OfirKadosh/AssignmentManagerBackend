import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})

export class SharedService {
  readonly BackendUrl = 'http://localhost:8800/';
  constructor(private http: HttpClient) {}

  signUp(val: any) {
    return this.http.post(this.BackendUrl + 'signup', val);
  }

  signIn(val: any) {
    return this.http.post(this.BackendUrl + 'signin', val);
  }

  getAllUsers():Observable<any>{
    return this.http.get(this.BackendUrl + "allusers");
  }

  updateUser(valId: any, val: any) {
    return this.http.put(this.BackendUrl + 'updateuser' + valId, val);
  }

  deleteUser(val: any) {
    return this.http.delete(this.BackendUrl + 'deleteuser' + val);
  }

  getAssignment(val: any): Observable<any> {
    return this.http.get(this.BackendUrl + 'assignment' + val);
  }

  addAssignment(val: any) {
    return this.http.post(this.BackendUrl + 'createassignment', val);
  }

  editAssignment(valId: any, val: any) {
    return this.http.put(this.BackendUrl + 'editassignment' + valId, val);
  }

  deleteAssignment(val: any) {
    return this.http.delete(this.BackendUrl + 'deleteassignment' + val);
  }

  getConditionAssignment(val: any): Observable<any[]> {
    return this.http.get<any>(this.BackendUrl + 'conditionassignment' + val);
  }

  getUserAssignmentsByDate(valId: any, val:any): Observable<any> {
    return this.http.get<any>(
      this.BackendUrl + 'userassignmentbydate' + valId, val);
  }
}
