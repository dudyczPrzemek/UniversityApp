import { FollowedUser } from '../../models/users/followed.user';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { OnInit, Injectable } from '@angular/core';
import { AuthenticationService } from '../authentication/authentication.service';
import { ActivatedRoute, Router } from '@angular/router';

@Injectable()
export class FollowedUsersService implements OnInit {
    public followedUsers = new BehaviorSubject<FollowedUser[]>([]);
    public currentSelectedFollowedUser = new BehaviorSubject<FollowedUser>(null);

    constructor(private http: Http, 
        private authService: AuthenticationService, 
        private route: ActivatedRoute, 
        private router: Router,) {
        this.load();
    }

    public ngOnInit() {
    }

    public load () {
        const followedUsersUrl = 'http://localhost:50985/api/followedUser';
        this.http.get(followedUsersUrl)
        .subscribe(result => {
            const followedUsersResult = result.json();
            this.followedUsers.next(followedUsersResult.followedUserArray);
        });
    }

    public refreshFacebookData (facebookId: string) {
        const facebookAccessToken = this.authService.getCurrentFacebookAccessToken()
        if (!facebookAccessToken)
        {
            this.authService.loginFacebookUser();
        }
        else {
            if(!facebookId) {
                this.router.navigate(['addfolloweduser'], { queryParams: { social: 'facebook' } });
            }
            else {
                const followedUserFbRefreshUrl = 
                    'http://localhost:50985/api/followedUser/refreshFacebook?facebookId=' + facebookId 
                    + '&accessToken=' + facebookAccessToken;
        
                this.http.get(followedUserFbRefreshUrl)
                    .subscribe(result => {
                        console.log('Facebok user refreshed');
                    });
            }
        }   
        
    }

    public refreshInstagramData (instagramId: string) {
        const instagramAccessToken = this.authService.getCurrentInstagramAccessToken();
        if (!instagramAccessToken) {
            this.authService.loginInstagramUser();
        }
        else {
            if(!instagramId) {
                //window.location.href = 'http://localhost:50985/addfolloweduser?social=instagram';;
                this.router.navigate(['addfolloweduser'], { queryParams: { social: 'instagram' } });
            }
            else {
                const followedUserInstaRefreshUrl = 
                    'http://localhost:50985/api/followedUser/refreshInstagram?instagramId=' + instagramId 
                    + '&accessToken=' + instagramAccessToken;
        
                this.http.get(followedUserInstaRefreshUrl)
                    .subscribe(result => {
                        console.log('Instagram user refreshed');
                    });
            }
        }
    }

    public refreshTwitterData (twitterId: string) {
        const twitterAccessToken = this.authService.getCurrentTwitterAccessToken();
        if (!twitterAccessToken) {
            this.authService.loginTwitterUser();
        }
        else {
            if(!twitterId) {
                this.router.navigate(['addfolloweduser'], { queryParams: { social: 'twitter' } });
            }
            else {
                const followedUserTwitterRefreshUrl = 
                    'http://localhost:50985/api/followedUser/refreshTwitter?twitterId=' + twitterId 
                    + '&accessToken=' + twitterAccessToken;
        
                this.http.get(followedUserTwitterRefreshUrl)
                    .subscribe(result => {
                        console.log(followedUserTwitterRefreshUrl);
                });
            }
        }
    } 
}
