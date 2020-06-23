using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Kino.Model.Requests;
using Kino.WebAPI.Database;
using Kino.WebAPI.Filters;
using Kino.WebAPI.Security;
using Kino.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.Reflection;

namespace Kino.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper(typeof(Startup));




            services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ISjedistaService, SjedistaService>();
            services.AddScoped<IPreporukeService, PreporukeService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();
            services.AddScoped<ICRUDService<Model.Filmovi, FilmoviSearchRequest, FilmoviInsertRequest, FilmoviInsertRequest>, FilmoviService>();
            services.AddScoped<ICRUDService<Model.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest>, ZanroviService>();
            services.AddScoped<ICRUDService<Model.Sale, SaleSearchRequest, SaleInsertRequest, SaleInsertRequest>, SaleService>();
            services.AddScoped<ICRUDService<Model.Projekcije, ProjekcijeSearchRequest, ProjekcijeInsertRequest, ProjekcijeInsertRequest>, ProjekcijeService>();
            services.AddScoped<ICRUDService<Model.Ulaznice, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest>, UlazniceService>();
            services.AddScoped<ICRUDService<Model.Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest>, KomentariService>();
            services.AddScoped<IKupciService, KupciService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            var connection = @"Server=.;Database=160102;Trusted_Connection=true;MultipleActiveResultSets=true";
            services.AddDbContext<Kino.WebAPI.EF.KinoContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<Kino.WebAPI.EF.KinoContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("KinoDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            app.UseSwagger();



            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });

            //app.UseRouting();

            app.UseAuthentication();
            //app.UseHttpsRedirection();
            app.UseMvc();

        }

    }

}


