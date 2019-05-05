using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TopoEditNetCore.REST.Models;

namespace TopoEditNetCore.REST.Persistence
{
  public interface ITopologyRepository
  {
    void Add(Topology topology);

    Task<IList<Topology>> GetTopologies(string filter = null);

    Task<Topology> GetTopology(string key, bool includeRelated = true);

    void Remove(Topology topology);
  }
}
