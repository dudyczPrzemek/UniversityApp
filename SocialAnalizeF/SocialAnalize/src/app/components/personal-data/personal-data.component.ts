import { Component, OnInit } from '@angular/core';
import { PersonalData } from '../../models/users/personal.data';
import { FollowedUsersService } from '../../services/followedUsers/followed.users.service';

@Component({
  selector: 'app-personal-data',
  templateUrl: './personal-data.component.html',
  styleUrls: ['./personal-data.component.scss']
})
export class PersonalDataComponent implements OnInit {
  followedUserPersonalData: PersonalData;
  constructor(private followedUserService: FollowedUsersService) { }

  ngOnInit() {
    this.followedUserPersonalData = this.followedUserService.currentSelectedFollowedUser.getValue().personalData;
  }

}
