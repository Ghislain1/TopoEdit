using System;
using System.ComponentModel.DataAnnotations;

namespace TopoEditNetCore.REST.Models
{
  public class TopologyDevicePort
  {
    [Key]
    public string Key { get; set; } = Guid.NewGuid().ToString();

    public string PortColor { get; set; }

    public string PortId { get; set; }
  }
}
