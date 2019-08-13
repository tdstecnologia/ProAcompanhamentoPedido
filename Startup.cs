using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProAcompanhamentoPedido.Dao;
using ProAcompanhamentoPedido.Models;

namespace ProAcompanhamentoPedido
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<PedidoRepository, PedidoRepository>();
            services.AddMvc();
            services.AddEntityFrameworkNpgsql()
         .AddDbContext<AcompanhamentoContexto>(options => options.UseNpgsql(Configuration.GetConnectionString("Conexao")));
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
