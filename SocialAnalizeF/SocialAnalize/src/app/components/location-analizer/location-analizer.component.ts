import { Component, OnInit } from '@angular/core';
import { LocalizationService } from '../../services/localization/localization.service';
import { FollowedUsersService } from '../../services/followedUsers/followed.users.service';
import { FollowedUser } from '../../models/users/followed.user';

@Component({
  selector: 'app-location-analizer',
  templateUrl: './location-analizer.component.html',
  styleUrls: ['./location-analizer.component.scss']
})
export class LocationAnalizerComponent implements OnInit {
  public followedUser: FollowedUser;
  public homeTown: string;
  public currentTown: string;
  public localizationArray = [];
  public startLat = 0;
  public startLog = 0;

  constructor(private localizationService: LocalizationService, private followedUserService: FollowedUsersService){}

  ngOnInit() {
    this.localizationService.getForCurrentUser().subscribe(result => {
      var localizations = result.json();
      this.localizationArray = localizations;

      if(this.localizationArray.length > 0) {
        this.startLat = this.localizationArray[0].latitude;
        this.startLog = this.localizationArray[0].longitude;
      }
    });

    this.followedUser = this.followedUserService.currentSelectedFollowedUser.getValue();
  }
}
