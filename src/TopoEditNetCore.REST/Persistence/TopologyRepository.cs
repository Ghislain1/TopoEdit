using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TopoEditNetCore.REST.Datacontext;
using TopoEditNetCore.REST.Models;

namespace TopoEditNetCore.REST.Persistence
{
  public class TopologyRepository : ITopologyRepository
  {
    private readonly TopoEditContext context;

    public TopologyRepository(TopoEditContext context)
    {
      this.context = context;
    }

    public void Add(Topology topology)
    {
      context.Topologies.Add(topology);
    }

    public async Task<IList<Topology>> GetTopologies(string filter = null)
    {
      var result = new List<Topology>();

      var query = context.Topologies
          .Include(t => t.NodeData)
          .Include(t => t.NodeData)
         .ThenInclude(n => n.TopPort)
        .AsQueryable();

      var columnsMap = new Dictionary<string, Expression<Func<Topology, object>>>()
      {
        ["key"] = v => v.Key,
        ["LinkDataArray"] = v => v.LinkDataArray,
        ["NodeDataArray"] = v => v.NodeDataArray
      };

      await Task.FromResult<int>(10);

      result = await query.ToListAsync();

      return result;
    }

    public async Task<Topology> GetTopology(string key, bool includeRelated = true)
    {
      if (!includeRelated)
        return await context.Topologies.FindAsync(key);

      return await context.Topologies
        .Include(v => v)
        .ThenInclude(vf => vf)
        .Include(v => v)
        .ThenInclude(m => m)
        .SingleOrDefaultAsync(v => v.Key == key);
    }

    public void Remove(Topology topology)
    {
      context.Remove(topology);
    }
  }
}
