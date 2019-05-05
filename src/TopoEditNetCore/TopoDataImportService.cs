using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopoEditNetCore.REST.Datacontext;
using TopoEditNetCore.REST.DTos;
using TopoEditNetCore.REST.Models;
using TopoEditNetCore.REST.Services;

namespace TopoEditNetCore
{
  public class TopoDataImportService : ITopoDataImportService
  {
    private readonly TopoEditContext topoEditContext;

    public TopoDataImportService(TopoEditContext topoEditContext)
    {
      this.topoEditContext = topoEditContext ?? throw new ArgumentNullException(nameof(topoEditContext));
    }

    public bool EnsureTopoData(string jsonDataFilePath)
    {
      bool hasData = false;
      try
      {
        hasData = this.topoEditContext.Topologies.Any();
      }
      catch
      {
        topoEditContext.Database.EnsureCreated(); // just create the schema - no migrations
                                                  // hasData = topoEditContext.NodeDataArray.Any() || topoEditContext.LinkDataArray.Any();
      }

      if (!hasData)
      {
        string json = System.IO.File.ReadAllText(jsonDataFilePath);
        return this.ImportFromJson(json);
      }

      return true;
    }

    /// <summary>
    /// </summary>
    /// <param name="json">json information as string</param>
    /// <returns></returns>
    private bool ImportFromJson(string json)
    {
      var topologyModel = JsonConvert.DeserializeObject<Topology>(json);

      //Add all Nodes to datatbase
      foreach (var nodeModel in topologyModel.NodeDataArray)
      {
        topologyModel.NodeData = nodeModel;
        topologyModel.NodeDataId = nodeModel.Key;

        this.topoEditContext.TopologyDevices.Add(nodeModel);
        this.topoEditContext.SaveChanges();

        foreach (var bottomPort in nodeModel.BottomPorts)
        {
          topologyModel.NodeData.BottomPort = bottomPort;
          topologyModel.NodeData.BottomPortId = bottomPort.Key;
          this.topoEditContext.TopologyDevicePorts.Add(bottomPort);
          this.topoEditContext.SaveChanges();
        }
        foreach (var rightPort in nodeModel.RightPorts)
        {
          topologyModel.NodeData.RightPort = rightPort;
          topologyModel.NodeData.RightPortId = rightPort.Key;
          this.topoEditContext.TopologyDevicePorts.Add(rightPort);
          this.topoEditContext.SaveChanges();
        }
        foreach (var topoPort in nodeModel.TopPorts)
        {
          topologyModel.NodeData.TopPort = topoPort;
          topologyModel.NodeData.TopPortId = topoPort.Key;
          this.topoEditContext.TopologyDevicePorts.Add(topoPort);
          this.topoEditContext.SaveChanges();
        }
        foreach (var leftPort in nodeModel.LeftArray)
        {
          topologyModel.NodeData.LeftPort = leftPort;
          topologyModel.NodeData.LeftPortId = leftPort.Key;
          // this.topoEditContext.TopologyDevicePorts.Add(leftPort);
          this.topoEditContext.SaveChanges();
        }
      }

      //Add all links to datatbase
      foreach (var linkModel in topologyModel.LinkDataArray)
      {
        topologyModel.LinkData = linkModel;
        topologyModel.LinkDataId = linkModel.Key;

        this.topoEditContext.TopologyDeviceLinks.Add(linkModel);
        this.topoEditContext.SaveChanges();
      }
      this.topoEditContext.Topologies.Add(topologyModel);
      return this.topoEditContext.SaveChanges() > 0;
    }
  }
}
