import { AuthenticationService } from './../../services/authentication/authentication.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Params } from '@angular/router/src/shared';

@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.scss']
})
export class AuthenticationComponent implements OnInit {

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private service: AuthenticationService) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      const facebookAccessToken = params['facebookAccessToken'];
      const instagramAccessToken = params['instagramAccessToken'];
      const twitterAccessToken = params['twitterAccessToken'];

      if (facebookAccessToken) {
        this.service.loginUser(facebookAccessToken, 'facebook');
        this.router.navigate(['addpage']);
      }

      if (instagramAccessToken) {
        this.service.loginUser(instagramAccessToken, 'instagram');
        this.router.navigate(['addpage']);
      }

      if (twitterAccessToken) {
        this.service.loginUser(twitterAccessToken, 'twitter');
        this.router.navigate(['addpage']);
      }
    });
  }

  useFacebookClick() {
    this.service.loginFacebookUser();
  }

  useInstagramClick() {
    this.service.loginInstagramUser();
  }

  useTweeterClick() {
    this.service.loginTwitterUser();
  }
}
