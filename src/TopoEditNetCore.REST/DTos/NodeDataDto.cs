using System.Collections.Generic;

namespace TopoEditNetCore.REST.DTos
{
  public class NodeDataDto
  {
    public NodeDataDto()
    {
      this.LeftArray = new List<TopologyDevicePortDto>();
      this.BottomtArray = new List<TopologyDevicePortDto>();
      this.RightArray = new List<TopologyDevicePortDto>();
      this.TopArray = new List<TopologyDevicePortDto>();
    }

    public List<TopologyDevicePortDto> BottomtArray { get; set; }
    public string Key { get; set; }
    public virtual IList<TopologyDevicePortDto> LeftArray { get; set; }
    public string Loc { get; set; }
    public string Name { get; set; }
    public virtual IList<TopologyDevicePortDto> RightArray { get; set; }
    public virtual IList<TopologyDevicePortDto> TopArray { get; set; }
  }
}
