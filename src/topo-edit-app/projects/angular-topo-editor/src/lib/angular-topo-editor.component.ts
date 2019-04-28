import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'topo-angular-topo-editor',
  // changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: 'angular-topo-editor.component.html',
  styles: []
})
export class AngularTopoEditorComponent implements OnInit {

  /** The current view date */
  @Input() displayDate: Date;

  constructor() { }

  ngOnInit() {
  }

}
