/*
 ref https://github.com/NuGet/NuGetGallery/blob/1eff45eac940922495af949ea30fda4daee6045f/src/NuGetGallery/Controllers/PackagesController.cs

 */

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using TopoEditNetCore.REST.Datacontext;
using TopoEditNetCore.REST.Persistence;

namespace TopoEditNetCore.REST
{
  [Route("api/[controller]")]
  [ApiController]
  public class DynamicPortsController : ControllerBase
  {
    private readonly IConfiguration configuration;
    private readonly IMapper mapper;
    private readonly IDynamicPortRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public DynamicPortsController(IMapper mapper, IConfiguration configuration, TopoEditContext topoEditContext)
    {
      this.mapper = mapper;
      this.configuration = configuration;
      string isSqLite = this.configuration["data:useSqLite"];
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1333333", "value2w3333" };
    }

    //[HttpGet]
    //public async Task<QueryResultResource<VehicleResource>> GetVehicles(VehicleQueryResource filterResource)
    //{
    //  var filter = mapper.Map<VehicleQueryResource, VehicleQuery>(filterResource);
    //  var queryResult = await repository.GetVehicles(filter);

    //  return mapper.Map<QueryResult<Vehicle>, QueryResultResource<VehicleResource>>(queryResult);
    //}
  }
}
