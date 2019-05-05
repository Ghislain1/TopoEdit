using System.Collections.Generic;

namespace TopoEditNetCore.REST.DTos
{
  public class NodeDataDto
  {
    public NodeDataDto()
    {
      this.LeftArray = new List<TopologyDevicePortDto>();
      this.BottomPorts = new List<TopologyDevicePortDto>();
      this.RightPorts = new List<TopologyDevicePortDto>();
      this.TopPorts = new List<TopologyDevicePortDto>();
    }

    public List<TopologyDevicePortDto> BottomPorts { get; set; }
    public string Key { get; set; }
    public virtual IList<TopologyDevicePortDto> LeftArray { get; set; }
    public string Loc { get; set; }
    public string Name { get; set; }
    public virtual IList<TopologyDevicePortDto> RightPorts { get; set; }
    public virtual IList<TopologyDevicePortDto> TopPorts { get; set; }
  }
}
