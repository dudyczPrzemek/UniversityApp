import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../services/authentication/authentication.service';
import { AccessTokens } from '../../models/access.token.model';
import { Http, Response, RequestOptions, Headers } from '@angular/http';

@Component({
  selector: 'app-add-start-page',
  templateUrl: './add-start-page.component.html',
  styleUrls: ['./add-start-page.component.scss']
})
export class AddStartPageComponent implements OnInit {
  searchedUserArray = [];

  constructor(private authService: AuthenticationService, private http: Http) { }

  ngOnInit() {
  }

  searchClick (userId) {
    const accessTokens: AccessTokens = this.authService.getAccessTokens();
    const baseUrl = 'http://localhost:50985/api/searchUser';
    const userIdUrlPart = `userId=${userId}`;
    const facebookUrlPart = `facebookAccessToken=${accessTokens.Facebook}`;
    const instagramUrlPart = `instagramAccessToken=${accessTokens.Instagram}`;
    const twitterUrlPart = `twitterAccessToken=${accessTokens.Twitter}`;
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

    this.http.post('http://localhost:50985/api/searchUser', userModel, options)
      .subscribe((result => {
        console.log('abc');
      }));
  }
}
