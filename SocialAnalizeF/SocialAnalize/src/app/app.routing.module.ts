import { CharacterAnalizerComponent } from './components/character-analizer/character-analizer.component';
import { ActivityAnalizerComponent } from './components/activity-analizer/activity-analizer.component';
import { LocationAnalizerComponent } from './components/location-analizer/location-analizer.component';
import { PersonalDataComponent } from './components/personal-data/personal-data.component';
import { AddStartPageComponent } from './components/add-start-page/add-start-page.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { AuthenticationComponent } from './components/authentication/authentication.component';
import { AddFollowedUserComponent } from './components/add-followed-user/add-followed-user.component';

const routes: Routes = [
    { path: '', redirectTo: 'login', pathMatch: 'full' },
    { path: 'login', component: AuthenticationComponent },
    { path: 'dashboard', component: DashboardComponent },
    { path: 'addpage', component: AddStartPageComponent},
    { path: 'addfolloweduser', component: AddFollowedUserComponent},
    { path: 'pesronaldata', component: PersonalDataComponent},
    { path: 'locationanalizer', component: LocationAnalizerComponent},
    { path: 'activityanalizer', component: ActivityAnalizerComponent},
    { path: 'characteranalizer', component: CharacterAnalizerComponent},
    { path: '**', redirectTo: 'login' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
