import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = ' topology editor component for angular 7+';

  currentDate;

  constructor() {
    this.currentDate = new Date();
  }
}
