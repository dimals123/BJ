﻿using BJ.DAL;
using BJ.DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BJ.BLL.Configrutions
{
    public static class DbContextConfigExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>();
            Initialize(services.BuildServiceProvider());
        }

        public static void Initialize(IServiceProvider service)
        {
            using (var serviceScope = service.CreateScope())
            {
                var scopeServiceProvider = serviceScope.ServiceProvider;
                var db = scopeServiceProvider.GetService<IBotRepository>();
                //db.CreateAsync()
                //BotsData.Initialize(db);
            }
        }
    }
}
