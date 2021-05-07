import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { EastListComponent } from '../east/east-list/east-list.component';
import { EastDetailComponent } from '../east/east-detail/east-detail.component';
import { WestListComponent } from '../west/west-list/west-list.component';
import { WestDetailComponent } from '../west/west-detail/west-detail.component';
import { NorthListComponent } from '../north/north-list/north-list.component';
import { NorthDetailComponent } from '../north/north-detail/north-detail.component';
import { SouthListComponent } from '../south/south-list/south-list.component';
import { SouthDetailComponent } from '../south/south-detail/south-detail.component';



const routes: Routes = [
  {path: '', redirectTo:'home',pathMatch:'full'},

  {path:'home', component: HomeComponent},

  {path: 'east/list', component: EastListComponent},
  {path: 'east/detail/:id', component: EastDetailComponent},
  {path: 'west/list', component: WestListComponent},
  {path: 'west/detail/:id', component: WestDetailComponent},
  {path: 'north/list', component: NorthListComponent},
  {path: 'north/detail/:id', component: NorthDetailComponent},
  {path: 'south/list', component: SouthListComponent},
  {path: 'south/detail/:id', component: SouthDetailComponent},
  


  {path:'**', component: HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
