import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { SideBarComponent } from './components/side-bar/side-bar.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { StatisticTagComponent } from './components/statistic-tag/statistic-tag.component';
import { CreateBookComponent } from './pages/create-book/create-book.component';
import { AppRoutingModule } from '../app-routing.module';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    DashboardComponent,
    SideBarComponent,
    StatisticTagComponent,
    CreateBookComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    AppRoutingModule,
    FormsModule
  ]
})
export class AdminModule { }
