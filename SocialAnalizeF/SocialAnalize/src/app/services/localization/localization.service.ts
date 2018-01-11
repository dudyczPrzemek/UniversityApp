import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { LocalizationModel } from "../../models/reports/localization.model";
import { FollowedUsersService } from "../followedUsers/followed.users.service";
import { BehaviorSubject } from "rxjs/BehaviorSubject";
import { Observable } from "rxjs/Observable";

@Injectable()
export class LocalizationService {
    constructor(private http: Http, private followedUserService: FollowedUsersService){}

    public getForCurrentUser(): Observable<Response>{
        debugger;
        const followedUser = this.followedUserService.currentSelectedFollowedUser.getValue();
        const localizationUrl = 'http://localhost:50985/api/localization?userId='+followedUser.id;
        return this.http.get(localizationUrl);
    }
}