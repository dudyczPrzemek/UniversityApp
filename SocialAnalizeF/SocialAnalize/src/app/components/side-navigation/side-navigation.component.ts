import { Router, ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-side-navigation',
  templateUrl: './side-navigation.component.html',
  styleUrls: ['./side-navigation.component.scss']
})
export class SideNavigationComponent {

  constructor(
    private router: Router,
    private route: ActivatedRoute
  ) {}

  dashboardClick() {
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
