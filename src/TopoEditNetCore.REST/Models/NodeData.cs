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
      this.BottomPorts = new Collection<TopologyDevicePort>();
      this.RightPorts = new Collection<TopologyDevicePort>();
      this.TopPorts = new Collection<TopologyDevicePort>();
    }

    public TopologyDevicePort BottomPort { get; set; }

    public string BottomPortId { get; set; }

    public ICollection<TopologyDevicePort> BottomPorts { get; set; }

    [Key]
    public string Key { get; set; }

    public ICollection<TopologyDevicePort> LeftArray { get; set; }
    public TopologyDevicePort LeftPort { get; set; }
    public string LeftPortId { get; set; }
    public string Loc { get; set; }
    public string Name { get; set; }
    public TopologyDevicePort RightPort { get; set; }
    public string RightPortId { get; set; }
    public ICollection<TopologyDevicePort> RightPorts { get; set; }
    public TopologyDevicePort TopPort { get; set; }
    public string TopPortId { get; set; }
    public ICollection<TopologyDevicePort> TopPorts { get; set; }
  }
}
