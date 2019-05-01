import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
import { LoginComponent } from './shared/components/login/login.component';
import { HomeComponent } from './shared/components/home/home.component';

// import { AngularTopoEditorModule } from 'projects/angular-topo-editor/src/lib/angular-topo-editor.module';

const appRoutes: Routes = [
  {
    path: 'gojs-sample',
    loadChildren: './custom-gojs/custom-gojs.module#CustomGojsModule'
  },
  {
    path: 'app-home',
    component: HomeComponent
  },
  {
    path: '',
    redirectTo: '/app-home',
    pathMatch: 'full'
  },
  {
    path: 'app-home/:id',
    component: LoginComponent
  },
  {
    path: 'heroes',
    component: LoginComponent,
    data: { title: 'Heroes List' }
  },


  // { path: '**', component: LoginComponent }
];

@NgModule({
  declarations: [
    AppComponent

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    ),
    SharedModule
    // AngularTopoEditorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
