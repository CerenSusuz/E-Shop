using EShop.Api.Extensions;
using EShop.Core.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Api
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.InstallAllService();
            ServiceTool.Create(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.InstallAllConfiguration(env);
        }
    }
}