using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Agenday.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; 

namespace Agenday
{
    public class Startup
    {

         public Startup(IConfiguration configuration) // Adicionando o construtor
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDataContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Configure os middleware da aplicação aqui.
        }
    }
}
