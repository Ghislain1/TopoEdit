using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TopoEditNetCore.REST.Models
{
  public class NodeData
  {
    public NodeData()
    {
      this.LeftArray = new Collection<TopologyDevicePort>();
      this.BottomtArray = new Collection<TopologyDevicePort>();
      this.RightArray = new Collection<TopologyDevicePort>();
      this.TopArray = new Collection<TopologyDevicePort>();
    }

    public ICollection<TopologyDevicePort> BottomtArray { get; set; }

    [Key]
    public string Key { get; set; }

    public ICollection<TopologyDevicePort> LeftArray { get; set; }
    public string Loc { get; set; }
    public string Name { get; set; }
    public ICollection<TopologyDevicePort> RightArray { get; set; }
    public ICollection<TopologyDevicePort> TopArray { get; set; }
  }
}
