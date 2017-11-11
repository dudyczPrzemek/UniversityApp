import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

export class AuthenticationService {

    public isLogged: BehaviorSubject<boolean> = new BehaviorSubject(this.isUserLogged());
    constructor() { }

    isUserLogged() {
        return true;
    }

    loginUser() {
        this.isLogged.next(true);
    }
}
