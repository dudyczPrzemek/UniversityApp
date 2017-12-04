import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable()
export class AuthenticationService {

    public isLogged: BehaviorSubject<boolean> = new BehaviorSubject(this.isUserLogged());
    constructor(private http: HttpClient) { }

    isUserLogged() {
        return true;
    }

    loginUser() {
        this.isLogged.next(true);
    }

    loginInstagramUser() {
        window.location.href = 'http://localhost:50985/api/instagramAuthentication/authenticate';
    }
}
