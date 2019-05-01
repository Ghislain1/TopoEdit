import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
// import { AngularTopoEditorModule } from 'projects/angular-topo-editor/src/lib/angular-topo-editor.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    SharedModule
    // AngularTopoEditorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
