import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { AssignmentsComponent } from './assignments/assignments.component';
import { EditAssignmentComponent } from './assignments/edit-assignment/edit-assignment.component';
import { AddAssignmentComponent } from './assignments/add-assignment/add-assignment.component';
import { DeleteAssignmentComponent } from './assignments/delete-assignment/delete-assignment.component';
import { UsersComponent } from './users/users.component';
import { AddUserComponent } from './users/add-user/add-user.component';
import { EditUserComponent } from './users/edit-user/edit-user.component';
import { DeleteUserComponent } from './users/delete-user/delete-user.component';
import { SharedService } from './shared.service';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    SignInComponent,
    SignUpComponent,
    AssignmentsComponent,
    EditAssignmentComponent,
    AddAssignmentComponent,
    DeleteAssignmentComponent,
    UsersComponent,
    AddUserComponent,
    EditUserComponent,
    DeleteUserComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule,
  ],
  providers: [SharedService],
  bootstrap: [AppComponent],
})
export class AppModule {}
