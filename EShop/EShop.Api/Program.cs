using Autofac;
using Autofac.Extensions.DependencyInjection;
using EShop.Business.Installers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EShop.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(b =>
                {
                    b.RegisterModule(new AutofacBusinessModule());
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}