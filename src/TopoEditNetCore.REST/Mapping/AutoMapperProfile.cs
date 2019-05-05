using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopoEditNetCore.REST.Mapping
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap(typeof(IEnumerable<>), typeof(IEnumerable<>));
      //CreateMap<Customer, CustomerViewModel>()
      //    .ReverseMap();
    }
  }
}
