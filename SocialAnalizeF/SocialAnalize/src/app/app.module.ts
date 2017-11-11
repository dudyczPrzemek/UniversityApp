import { IconRegistry } from './utilities/icons/icons.registry';
import { TopNavigationComponent } from './components/top-navigation/top-navigation.component';
import { AuthenticationService } from './services/authentication/authentication.service';
import { SideNavigationComponent } from './components/side-navigation/side-navigation.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppRoutingModule } from './app.routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { MatIconModule } from '@angular/material';

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
    TopNavigationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule
  ],
  providers: [
    AuthenticationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
