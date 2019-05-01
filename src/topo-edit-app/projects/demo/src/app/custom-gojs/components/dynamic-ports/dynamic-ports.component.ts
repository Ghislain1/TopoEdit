import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dynamic-ports',
  templateUrl: './dynamic-ports.component.html',
  styleUrls: ['./dynamic-ports.component.css']
})
export class DynamicPortsComponent implements OnInit {
  myDate: Date;
  constructor() { }

  ngOnInit() {
    this.myDate = new Date();
  }

}
