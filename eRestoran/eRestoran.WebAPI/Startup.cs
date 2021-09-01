using AutoMapper;
using eRestoran.WebAPI.Security;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Filters;

using eRestoran.WebAPI.Services;
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
using System.Collections.Generic;

namespace eRestoran
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
            services.AddAutoMapper();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            //});



            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);



            //var connection = @"Server=.;Database=eRestoran6;Trusted_Connection=True;ConnectRetryCount=0";
            //services.AddDbContext<eRestoranContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<eRestoranContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("Test")));

            //services.AddScoped<ICRUDService<Model.Korisnik, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciInsertRequest>, KorisniciService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest>, ObavijestService>();
            //services.AddScoped<IObavijestService, ObavijestService>();
            services.AddScoped<IService<Model.JediniceMjere, object>, BaseService<Model.JediniceMjere, object, JediniceMjere>>();
            //services.AddScoped<IService<Model.Kategorija, object>, BaseService<Model.Kategorija, object, Kategorija>>();
            //services.AddScoped<ICRUDService<Model.Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>, KategorijaService>();
            services.AddScoped<ICRUDService<Model.Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>, KategorijaService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();
            services.AddScoped<ICRUDService<Model.Proizvodi, ProizvodiSearchRequest, ProizvodiUpsertRequest, ProizvodiUpsertRequest>, ProizvodiService>();
            services.AddScoped<ICRUDService<Model.Narudzbe, NarudzbeSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>, NarudzbaService>();
            services.AddScoped<ICRUDService<Model.NarudzbaProizvod, NarudzbaProizvodSearchRequest, NarudzbaProizvodUpsertRequest, NarudzbaProizvodUpsertRequest>, NarudzbaProizvodService>();
            services.AddScoped<IService<Model.NarudzbaStatus, object>, BaseService<Model.NarudzbaStatus, object, NarudzbaStatus>>();
            services.AddScoped<ICRUDService<Model.Informacije, InformacijeSearchRequest, InformacijeUpsertRequest, InformacijeUpsertRequest>, InformacijeService>();
            services.AddScoped<ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest>, OcjeneService>();
            services.AddScoped<IRecommender, RecommenderService>();
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
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
