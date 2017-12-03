import { HttpClientModule } from '@angular/common/http';
import { CharacterAnalizerComponent } from './components/character-analizer/character-analizer.component';
import { ActivityAnalizerComponent } from './components/activity-analizer/activity-analizer.component';
import { LocationAnalizerComponent } from './components/location-analizer/location-analizer.component';
import { PersonalDataComponent } from './components/personal-data/personal-data.component';
import { AddStartPageComponent } from './components/add-start-page/add-start-page.component';
import { IconRegistry } from './utilities/icons/icons.registry';
import { TopNavigationComponent } from './components/top-navigation/top-navigation.component';
import { AuthenticationService } from './services/authentication/authentication.service';
import { SideNavigationComponent } from './components/side-navigation/side-navigation.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppRoutingModule } from './app.routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { MatIconModule } from '@angular/material';
import { AgmCoreModule } from '@agm/core';
import { NgxChartsModule } from '@swimlane/ngx-charts';

import { AppComponent } from './components/app/app.component';
import { AuthenticationComponent } from './components/authentication/authentication.component';

export function appInitializeFactory(iconRegistry: IconRegistry): Function {
  return async () => {
    iconRegistry.registerDefaultSvgIcons();
  };
}

@NgModule({
  declarations: [
    AppComponent,
    AuthenticationComponent,
    DashboardComponent,
    SideNavigationComponent,
    TopNavigationComponent,
    AddStartPageComponent,
    PersonalDataComponent,
    LocationAnalizerComponent,
    ActivityAnalizerComponent,
    CharacterAnalizerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyBr3iyBE5CDyJGhg5qJNaXEXJgtqRzY0bg'
    }),
    NgxChartsModule,
    HttpClientModule
  ],
  providers: [
    AuthenticationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
