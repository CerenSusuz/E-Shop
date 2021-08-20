using AutoMapper;
using EShop.Api.Middlewares;
using EShop.Business.Abstract;
using EShop.Business.Concrete;
using EShop.Business.Installers.Profiles;
using EShop.Business.Repositories;
using EShop.Core.Plugins.Caching;
using EShop.Core.Plugins.Caching.Redis;
using EShop.DataAccess.Contexts.EF;
using EShop.DataAccess.Repositories;
using EShop.DataAccess.Repositories.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EShop.Api
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
            services.AddSingleton<EShopContext>();
            
            // generic olduğu için typeof şeklinde tanımlanmalı
            
            services.AddSingleton(typeof(IRepository<>), typeof(EfRepository<>));
            
            services.AddSingleton(typeof(IServiceRepository<>), typeof(ServiceRepository<,>));
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IUserGroupService, UserGroupService>();

            services.AddSingleton(
                new MapperConfiguration(x =>
                    x.AddProfile(new AutoMapperProfile()))
                    .CreateMapper());
            
            
            services.AddSingleton<IRedisServer, RedisServer>();
            services.AddSingleton<ICacheService, RedisCacheService>();
            var opt = new RedisOption
            {
                InstanceName = "EShop.Api",
                ConnectionString = "localhost:6376,ssl=False",
                AbsoluteExpiration = 60
            };
            services.AddSingleton(opt);
            
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "EShop.Api", Version = "v1"}); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EShop.Api v1"));
            }

            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}