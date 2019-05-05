using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// e.g. https://exceptionnotfound.net/entity-framework-and-wcf-mapping-entities-to-dtos-with-automapper/
/// </summary>
namespace TopoEditNetCore.REST.DTos
{
  public class TopologyDto
  {
    public TopologyDto()
    {
      this.LinkDataArray = new List<LinkDataDto>();
      this.NodeDataArray = new List<NodeDataDto>();
    }

    public virtual IList<LinkDataDto> LinkDataArray { get; set; }
    public virtual IList<NodeDataDto> NodeDataArray { get; set; }
  }
}
