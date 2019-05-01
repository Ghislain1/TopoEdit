import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Routes, RouterModule } from '@angular/router';
import { GojsDashboardComponent } from './components/gojs-dashboard/gojs-dashboard.component';
import { GojsTableComponent } from './components/gojs-table/gojs-table.component';
import { DynamicPortsComponent } from './components/dynamic-ports/dynamic-ports.component';

const gojsRoutes: Routes = [
  {
    path: '',
    component: GojsDashboardComponent,
    children: [
      {
        path: 'app-gojs-table',
        component: GojsTableComponent
      },
      {
        path: 'app-dynamic-ports',
        component: DynamicPortsComponent
      }
    ]
  },



];

@NgModule({
  declarations: [GojsDashboardComponent, GojsTableComponent, DynamicPortsComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(gojsRoutes),
  ]
})
export class CustomGojsModule { }
