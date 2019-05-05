using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TopoEditNetCore.REST.Datacontext
{
  public class TopoEditContext : DbContext
  {
    public TopoEditContext(DbContextOptions options) : base(options)
    {
    }

    public string ConnectionString { get; set; }
    public DbSet<Object> LinkDataArray { get; set; }
    public DbSet<Object> NodeDataArray { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
