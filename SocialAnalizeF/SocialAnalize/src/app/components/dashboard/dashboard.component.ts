import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FollowedUser } from '../../models/users/followed.user';
import { FollowedUsersService } from '../../services/followedUsers/followed.users.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  public currentFollowedUser: FollowedUser;
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private followedUserService: FollowedUsersService) { }

  ngOnInit() {
    this.currentFollowedUser = this.followedUserService.currentSelectedFollowedUser.getValue();
  }

  public facebookRefresh() {
    this.followedUserService.refreshFacebookData(this.currentFollowedUser.facebookId);
  }

  public instagramRefresh() {
    this.followedUserService.refreshInstagramData(this.currentFollowedUser.instagramId);
  }

  public twitterRefresh() {
    this.followedUserService.refreshTwitterData(this.currentFollowedUser.twitterId);
  }
}
