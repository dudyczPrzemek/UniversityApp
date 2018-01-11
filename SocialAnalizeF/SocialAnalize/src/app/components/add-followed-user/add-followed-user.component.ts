import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../services/authentication/authentication.service';
import { AccessTokens } from '../../models/access.token.model';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { ActivatedRoute } from '@angular/router';
import { FollowedUsersService } from '../../services/followedUsers/followed.users.service';

@Component({
  selector: 'app-add-followed-user',
  templateUrl: './add-followed-user.component.html',
  styleUrls: ['./add-followed-user.component.scss']
})
export class AddFollowedUserComponent implements OnInit {
  searchedUserArray = [];
  public social: string;

  constructor(private authService: AuthenticationService, 
    private http: Http, 
    private route: ActivatedRoute,
    private followedUsersService: FollowedUsersService) { }

  ngOnInit() {
    debugger;
    this.route.queryParams.subscribe(params => {
      debugger;
      this.social = params['social'];
    });
  }

  searchClick (userId) {
    const accessTokens: AccessTokens = this.authService.getAccessTokens();
    const baseUrl = 'http://localhost:50985/api/searchUser';
    const userIdUrlPart = `userId=${userId}`;
    const facebookUrlPart = this.social == 'facebook'? `facebookAccessToken=${accessTokens.Facebook}`: 'facebookAccessToken=null';
    const instagramUrlPart = this.social == 'instagram'? `instagramAccessToken=${accessTokens.Instagram}`: 'instagramAccessToken=null';
    const twitterUrlPart = this.social == 'twitter'? `twitterAccessToken=${accessTokens.Twitter}` : 'twitterAccessToken=null';
    this.http.get(`http://localhost:50985/api/searchUser?${userIdUrlPart}&${facebookUrlPart}&${instagramUrlPart}&${twitterUrlPart}`)
      .subscribe ((result) => {
        const searchResult = result.json();
        this.searchedUserArray = searchResult.searchedUsers;
      });
  }

  onUserDblClick (userModel) {
    const postHeaders = new Headers();
    postHeaders.append('Accept', 'application/json');
    postHeaders.append('Content-Type', 'application/json');
    const options = new RequestOptions({ headers: postHeaders });
    const accessTokens: AccessTokens = this.authService.getAccessTokens();
    userModel.userId = this.followedUsersService.currentSelectedFollowedUser.getValue().id;
    this.http.put('http://localhost:50985/api/followedUser', {searchUser: userModel, accessTokens: accessTokens} , options)
      .subscribe((result => {
        console.log('abc');
      }));
  }
}
