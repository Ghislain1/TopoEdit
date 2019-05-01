using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TopoEditNetCore.REST
{
  [Route("api/[controller]")]
  [ApiController]
  public class DynamicPortsController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1333333", "value2w3333" };
    }
  }
}
