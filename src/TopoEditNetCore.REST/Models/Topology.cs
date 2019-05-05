namespace TopoEditNetCore.REST.Models
{
  using System;
  using System.Collections.Generic;
  using System.Collections.ObjectModel;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Text;

  [Table("Topologies")]
  public class Topology
  {
    public Topology()
    {
      this.NodeDataArray = new Collection<NodeData>();
      this.LinkDataArray = new Collection<LinkData>();
    }

    [Key]
    public string Key { get; internal set; } = Guid.NewGuid().ToString();

    public LinkData LinkData { get; set; }
    public ICollection<LinkData> LinkDataArray { get; set; }
    public string LinkDataId { get; set; }
    public NodeData NodeData { get; set; }
    public ICollection<NodeData> NodeDataArray { get; set; }
    public string NodeDataId { get; set; }
  }
}
