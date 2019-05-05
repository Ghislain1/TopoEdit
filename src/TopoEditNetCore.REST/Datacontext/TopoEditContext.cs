using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TopoEditNetCore.REST.Models;

namespace TopoEditNetCore.REST.Datacontext
{
  public class TopoEditContext : DbContext
  {
    public TopoEditContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Topology> Topologies { get; set; }

    public DbSet<LinkData> TopologyDeviceLinks { get; set; }

    public DbSet<TopologyDevicePort> TopologyDevicePorts { get; set; }
    public DbSet<NodeData> TopologyDevices { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
