import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { SideBarComponent } from './components/side-bar/side-bar.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { StatisticTagComponent } from './components/statistic-tag/statistic-tag.component';



@NgModule({
  declarations: [
    DashboardComponent,
    SideBarComponent,
    StatisticTagComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule
  ]
})
export class AdminModule { }
