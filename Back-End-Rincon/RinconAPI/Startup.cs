using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RinconBL.Services;
using RinconBL.Services.IServices;
using RinconDL.Contexts;
using RinconDL.UOW;

namespace RinconAPI
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
            services.AddControllers();

            services.AddDbContext<RinconContext>(options => options.UseSqlite("Data Source=.\\publish\\RinconDB.db;", b => b.MigrationsAssembly("RinconAPI")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICartaService, CartaService>();
            services.AddScoped<ICartaVendedorService, CartaVendedorService>();
            services.AddScoped<ICarritoService, CarritoService>();
            services.AddScoped<IJuegoService, JuegoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddSwaggerGen();

            services.AddCors(o => o.AddPolicy("Cors", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("Cors");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
