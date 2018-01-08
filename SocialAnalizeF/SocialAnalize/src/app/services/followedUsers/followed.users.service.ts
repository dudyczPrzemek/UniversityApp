import { FollowedUser } from '../../models/users/followed.user';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { OnInit, Injectable } from '@angular/core';

@Injectable()
export class FollowedUsersService implements OnInit {
    public followedUsers = new BehaviorSubject<FollowedUser[]>([]);
    public currentSelectedFollowedUser = new BehaviorSubject<FollowedUser>(null);

    constructor(private http: Http) {
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
}
