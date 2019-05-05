/*
 ref https://github.com/NuGet/NuGetGallery/blob/1eff45eac940922495af949ea30fda4daee6045f/src/NuGetGallery/Controllers/PackagesController.cs

 */

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopoEditNetCore.REST.Datacontext;
using TopoEditNetCore.REST.DTos;
using TopoEditNetCore.REST.Models;
using TopoEditNetCore.REST.Persistence;

namespace TopoEditNetCore.REST
{
  [Route("api/[controller]")]
  [ApiController]
  public class DynamicPortsController : ControllerBase
  {
    private readonly IConfiguration configuration;
    private readonly IMapper mapper;
    private readonly ITopologyRepository repository;
    private readonly TopoEditContext topoEditContext;
    private readonly IUnitOfWork unitOfWork;

    public DynamicPortsController(IMapper mapper,
      IConfiguration configuration,
      ITopologyRepository repository,
      TopoEditContext topoEditContext)
    {
      this.mapper = mapper;
      this.configuration = configuration;
      this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
      this.topoEditContext = topoEditContext ?? throw new ArgumentNullException(nameof(topoEditContext));
    }

    // GET api/values

    [HttpGet]
    public async Task<IEnumerable<TopologyDto>> GetAll()
    {
      var all = await this.repository.GetTopologies();

      var queryResult = this.mapper.Map<IList<Topology>, IList<TopologyDto>>(all);

      return queryResult;
    }
  }
}
