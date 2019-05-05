using System.ComponentModel.DataAnnotations;

namespace TopoEditNetCore.REST.Models
{
  public class LinkData
  {
    public string From { get; set; }

    public string FromPort { get; set; }

    [Key]
    public string Key { get; set; }

    public string To { get; set; }
    public string ToPort { get; set; }
  }
}
