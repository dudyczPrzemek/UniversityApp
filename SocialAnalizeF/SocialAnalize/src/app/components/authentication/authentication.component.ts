import { AuthenticationService } from './../../services/authentication/authentication.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.scss']
})
export class AuthenticationComponent {

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private service: AuthenticationService) { }

  useFacebookClick() {
    this.router.navigate(['addpage']);
    this.service.loginUser();
  }

  useInstagramClick() {
     // this.router.navigate(['addpage']);
    this.service.loginInstagramUser();
  }

  useTweeterClick() {
    this.router.navigate(['addpage']);
    this.service.loginUser();
  }
}
