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

 
    public string ConnectionString { get; set; }

    //public DbSet<TopologyDevicePort> LeftPorts { get; set; }
    public DbSet<LinkData> LinkDataArray { get; set; }

    public DbSet<NodeData> NodeDataArray { get; set; }

    public DbSet<Topology> Topologies { get; set; }

    // public DbSet<TopologyDevicePort> TopPorts { get; set; }

    public DbSet<TopologyDevicePort> TopologyDevicePorts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
