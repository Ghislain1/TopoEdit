using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace TopoEditNetCore
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
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
      app.UseCors("CorsPolicy");
      app.UseHttpsRedirection();
      app.UseMvc();
      app.UseDefaultFiles(); // so index.html is not required

      app.UseSpa(spa =>
      {
        if (env.IsDevelopment())
        {
          spa.UseProxyToSpaDevelopmentServer("http://localhost:50001");
        }
      });

      // catch-all handler for HTML5 client routes - serve index.html
      app.Run(async context =>
      {
        // Make sure Angular output was created in wwwroot Running Angular in dev mode nukes output
        // folder! so it could be missing.
        if (env.WebRootPath == null)
          throw new InvalidOperationException("wwwroot folder doesn't exist. Please recompile your Angular Project before accessing index.html. API calls will work fine.");

        context.Response.ContentType = "text/HTML";
        var indexFile = Path.Combine(env.WebRootPath, "index.html");
        await context.Response.SendFileAsync(indexFile);
      });
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
        .AddJsonOptions(opt =>
        {
          var resolver = opt.SerializerSettings.ContractResolver;
          if (resolver != null)
          {
            var res = resolver as DefaultContractResolver;
            res.NamingStrategy = null;
          }

          opt.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        });
      // Cors policy is added to controllers via [EnableCors("CorsPolicy")] or .UseCors("CorsPolicy") globally
      services.AddCors(options =>
      {
        options.AddPolicy("CorsPolicy",
            builder => builder
                // required if AllowCredentials is set also
                .SetIsOriginAllowed(s => true)
                //.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
            );
      });
    }
  }
}
