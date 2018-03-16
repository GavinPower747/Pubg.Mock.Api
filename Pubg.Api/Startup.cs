using JsonApiSerializer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Buffers;

namespace Pubg.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var sp = services.BuildServiceProvider();
            var logger = sp.GetService<ILoggerFactory>();
            var objectPoolProvider = sp.GetService<ObjectPoolProvider>();

            services.AddMvc(opt => {
                var serializerSettings = new JsonApiSerializerSettings();

                var jsonApiFormatter = new JsonOutputFormatter(serializerSettings, ArrayPool<Char>.Shared);
                opt.OutputFormatters.RemoveType<JsonOutputFormatter>();
                opt.OutputFormatters.Insert(0, jsonApiFormatter);

                var jsonApiInputFormatter = new JsonInputFormatter(logger.CreateLogger<JsonInputFormatter>(), serializerSettings, ArrayPool<Char>.Shared, objectPoolProvider);
                opt.InputFormatters.RemoveType<JsonInputFormatter>();
                opt.InputFormatters.Insert(0, jsonApiInputFormatter);

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
