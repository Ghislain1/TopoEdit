import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
// import { AngularTopoEditorModule } from 'projects/angular-topo-editor/src/lib/angular-topo-editor.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    // AngularTopoEditorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
