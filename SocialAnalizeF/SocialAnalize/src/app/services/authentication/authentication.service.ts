import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { AccessTokens } from '../../models/access.token.model';

@Injectable()
export class AuthenticationService {

    public isLogged: BehaviorSubject<boolean> = new BehaviorSubject(this.isUserLogged());
    constructor(private http: HttpClient) { }

    isUserLogged(): boolean {
        const facebookAccessToken = this.getCurrentFacebookAccessToken();
        const instagramAccessToken = this.getCurrentInstagramAccessToken();
        const twitterAccessToken = this.getCurrentTwitterAccessToken();
        return facebookAccessToken !== null || instagramAccessToken !== null || twitterAccessToken !== null;
    }

    loginUser(accessToken: string, socialMediaType: string) {
        this.isLogged.next(true);
        localStorage.setItem(`${socialMediaType}AccessToken`, accessToken);
    }

    getCurrentFacebookAccessToken() {
        return localStorage.getItem('facebookAccessToken');
    }

    getCurrentInstagramAccessToken() {
        return localStorage.getItem('instagramAccessToken');
    }

    getCurrentTwitterAccessToken() {
        return localStorage.getItem('twitterAccessToken');
    }

    getAccessTokens(): AccessTokens {
        const accessTokensModel = new AccessTokens();
        accessTokensModel.Facebook = this.getCurrentFacebookAccessToken();
        accessTokensModel.Instagram = this.getCurrentInstagramAccessToken();
        accessTokensModel.Twitter = this.getCurrentTwitterAccessToken();
        return accessTokensModel;
    }

    loginInstagramUser() {
        window.location.href = 'http://localhost:50985/api/instagramAuthentication/authenticate';
    }

    loginFacebookUser() {
        window.location.href = 'http://localhost:50985/api/facebookAuthentication/authenticate';
    }

    loginTwitterUser() {
        window.location.href = 'http://localhost:50985/api/twitterAuthentication/authenticate';
    }
}
