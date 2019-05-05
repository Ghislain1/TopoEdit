using System.Collections.Generic;

namespace TopoEditNetCore.REST.DTos
{
  public class LinkDataDto
  {
    public string From { get; set; }
    public string FromPort { get; set; }
    public string To { get; set; }
    public string ToPort { get; set; }
  }
}
