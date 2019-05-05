using System;
using System.Collections.Generic;
using System.Text;
using TopoEditNetCore.REST.Datacontext;

namespace TopoEditNetCore.REST.Services
{
  public interface ITopoDataImportService
  {
    bool EnsureTopoData(string filePath);
  }
}
