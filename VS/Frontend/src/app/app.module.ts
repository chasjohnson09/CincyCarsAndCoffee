import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EastDetailComponent } from './east/east-detail/east-detail.component';
import { WestDetailComponent } from './west/west-detail/west-detail.component';
import { NorthDetailComponent } from './north/north-detail/north-detail.component';
import { NorthListComponent } from './north/north-list/north-list.component';
import { SouthDetailComponent } from './south/south-detail/south-detail.component';
import { SouthListComponent } from './south/south-list/south-list.component';
import { EastListComponent } from './east/east-list/east-list.component';
import { WestListComponent } from './west/west-list/west-list.component';
import { AppRoutingModule } from './app-routing.module';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    EastDetailComponent,
    WestDetailComponent,
    NorthDetailComponent,
    NorthListComponent,
    SouthDetailComponent,
    SouthListComponent,
    EastListComponent,
    WestListComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
