import { Component, OnInit } from '@angular/core';
import { GojsService } from '../../../shared/services/gojs.service';
import { DiagramModel } from '../../../shared/api/backend.result';

@Component({
  selector: 'app-dynamic-ports',
  templateUrl: './dynamic-ports.component.html',
  styleUrls: ['./dynamic-ports.component.css']
})
export class DynamicPortsComponent implements OnInit {
  myDate: Date;

  diagramModels: DiagramModel[];


  constructor(
    private gojsService: GojsService
  ) { }

  ngOnInit() {
    this.myDate = new Date();
  }
  getDynamicPorts(): void {
    this.gojsService.getDynamicPorts()
      .subscribe(diagramModels => this.diagramModels = diagramModels);
  }
}
