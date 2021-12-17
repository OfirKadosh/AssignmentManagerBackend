import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UsersComponent } from './users/users.component';
import { AssignmentsComponent } from './assignments/assignments.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';

const routes: Routes = [
  {path: "signin", component:SignInComponent},
  {path: "signup", component:SignUpComponent},
  {path: "users", component:UsersComponent},
  {path: "assignments", component:AssignmentsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
