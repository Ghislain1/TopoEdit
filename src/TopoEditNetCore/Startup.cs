using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using TopoEditNetCore.Mapping;
using TopoEditNetCore.REST.Datacontext;

namespace TopoEditNetCore
{
  public class Startup
  {
    private IHostingEnvironment hostingEnvironment;

    public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
    {
      Configuration = configuration;
      this.hostingEnvironment = hostingEnvironment;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios,
        // see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
      string useSqLite = Configuration["Data:useSqLite"];
      Console.WriteLine(useSqLite == "true" ? "SqLite" : "Sql Server");
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      //Support auto Mappper
      services.AddAutoMapper(typeof(Startup));

      services.AddDbContext<TopoEditContext>(builder =>
      {
        string useSqLite = this.Configuration["Data:useSqLite"];
        if (useSqLite != "true")
        {
          var connStr = Configuration["Data:SqlServerConnectionString"];
          // builder.UseSqlServer(connStr, opt => opt.EnableRetryOnFailure());
        }
        else
        {
          // Note this path has to have full access for the Web user in order to create the DB and
          // write to it.
          var connStr = $"Data Source={Path.Combine(this.hostingEnvironment.ContentRootPath, "TopoData.sqlite")}";
          builder.UseSqlite(connStr);
        }
      });
    }
  }
}
