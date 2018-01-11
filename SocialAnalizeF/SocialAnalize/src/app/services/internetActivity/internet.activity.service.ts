import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { FollowedUsersService } from "../followedUsers/followed.users.service";
import { Observable } from "rxjs/Observable";

@Injectable()
export class InternetActivityService {
    constructor(private http: Http, private followedUserService: FollowedUsersService){}

    public load(): Observable<Response>{
        const userId = this.followedUserService.currentSelectedFollowedUser.getValue().id;
        const internetActivityUrl = 'http://localhost:50985/api/internetActivity?userId=' + userId; 
        return this.http.get(internetActivityUrl);
    }
}