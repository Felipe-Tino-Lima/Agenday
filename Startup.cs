using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Agenday
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure os serviços da aplicação aqui.
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
