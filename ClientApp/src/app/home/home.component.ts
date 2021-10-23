import { Component } from '@angular/core';
import { AuthorizeService } from '../../api-authorization/authorize.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  //constructor(private authorize: AuthorizeService) {
  //  this.authorize.isAuthenticated().subscribe(this.RedirectIfNotAuthenticated);
  //}

  //RedirectIfNotAuthenticated(isAuthed: boolean) {
  //  debugger;
  //  if (!isAuthed) {
  //    location.href = "/Identity/Account/Login";
  //  }
  //}
}
