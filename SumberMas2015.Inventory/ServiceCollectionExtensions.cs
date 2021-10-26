﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInventory(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<InventoryContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}