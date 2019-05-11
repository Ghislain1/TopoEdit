export class BackendResult {
  response: any;
  responseHeader: object;
  spellcheck: any;
}

export class DiagramModel {
  linkDataArray: LinkData[];
  nodeDataArray: NodeData[];
  title: string;
}
export class LinkData {
  from: string;
  to: string;
  fromPort: string;
  toPort: string;
}

export class NodeData {
  from: string;
  name: string;
  loc: string;
  bottomPorts: any[];
  leftArray: any[];
  rightPorts: any[];
  topPorts: any[];
}
