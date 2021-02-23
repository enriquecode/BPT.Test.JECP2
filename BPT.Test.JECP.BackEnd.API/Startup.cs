using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BPT.Test.JECP.BackEnd.API.Interfaces;
using BPT.Test.JECP.BackEnd.API.Repositories;
using BPT.Test.JECP.BackEnd.API.DataAccess;
//using BPT.Test.JECP.BackEnd.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BPT.Test.JECP.BackEnd.API
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
           var sqlConnectionString = Configuration.GetConnectionString("EscuelaConnection");

            services.AddDbContext<SQLServerContext>(options =>
                       options.UseSqlServer(sqlConnectionString), ServiceLifetime.Transient);

            //.AddDbContext<SQLServerContext>(options => options.UseNpgsql(sqlConnectionString));

            //services.AddDbContext<EscuelaEntities> (ServiceLifetime.Scoped);
            // services.AddScoped(provider => new EscuelaEntities(sqlConnectionString));

            //services.AddDbContext<EscuelaEntities>(options => { });

            //services.AddEntityFramework.AddDbContext<EscuelaEntities>(options => { });

            //services.AddEntityFrameworkSqlServer();

            ////     services.AddDbContext<EscuelaEntities>(options =>
            ////options.UseSqlServer(
            ////    Configuration.GetConnectionString("DefaultConnection")));

            //services.AddScoped(provider => new EscuelaEntities());


            //IServiceCollection serviceCollections = services.AddDbContext<EscuelaEntities>(options =>
            //        options.UseSqlServer(sqlConnectionString), ServiceLifetime.Transient);

            //este es el mas cercano a EF6
            //ESTA LINEA FUE CON LA QUE ME ATORE, INSTALE ENTITY FRAMEWORK 6 Y NO JALO TAMPOCO
            //services.AddDbContext<EscuelaEntities>(options =>
            //           options.UseSqlServer(sqlConnectionString), ServiceLifetime.Transient);

            services.AddScoped<IStudentsRepository, StudentsRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
