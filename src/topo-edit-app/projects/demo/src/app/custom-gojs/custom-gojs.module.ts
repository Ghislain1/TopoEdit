import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Routes, RouterModule } from '@angular/router';
import { GojsDashboardComponent } from './components/gojs-dashboard/gojs-dashboard.component';
import { GojsTableComponent } from './components/gojs-table/gojs-table.component';

const gojsRoutes: Routes = [
  {
    path: '',
    component: GojsDashboardComponent,
    children: [
      {
        path: 'app-gojs-table',
        component: GojsTableComponent
      }
    ]
  },



];

@NgModule({
  declarations: [GojsDashboardComponent, GojsTableComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(gojsRoutes),
  ]
})
export class CustomGojsModule { }
