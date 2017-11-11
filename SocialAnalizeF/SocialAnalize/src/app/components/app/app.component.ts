import { AuthenticationService } from './../../services/authentication/authentication.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'SocialAnalize';
  isLogged: Boolean;

  constructor(private service: AuthenticationService) {
    this.isLogged = service.isLogged.getValue();
  }

  ngOnInit() {
    this.service.isLogged.subscribe(isLogged => {
      this.isLogged = isLogged;
    });
  }
}
