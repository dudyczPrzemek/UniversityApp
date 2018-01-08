import { Router, ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FollowedUsersService } from '../../services/followedUsers/followed.users.service';
import { FollowedUser } from '../../models/users/followed.user';

@Component({
  selector: 'app-side-navigation',
  templateUrl: './side-navigation.component.html',
  styleUrls: ['./side-navigation.component.scss']
})
export class SideNavigationComponent implements OnInit {
  public followedUsers =  [];

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private followedUsersService: FollowedUsersService
  ) {}

  public ngOnInit() {
    this.followedUsersService.followedUsers.subscribe(followedUsersArray => {
      this.followedUsers = followedUsersArray;
    });
  }

  dashboardClick(followedUser) {
    this.followedUsersService.currentSelectedFollowedUser.next(followedUser);
    this.router.navigate(['dashboard']);
  }
  personalDataClick() {
    this.router.navigate(['pesronaldata']);
  }
  locationClick() {
    this.router.navigate(['locationanalizer']);
  }
  activityClick() {
    this.router.navigate(['activityanalizer']);
  }
  characterClick() {
    this.router.navigate(['characteranalizer']);
  }
}
