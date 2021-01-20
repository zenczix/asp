﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
namespace CasCap.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection AddControllersAsServices(this IServiceCollection services, IEnumerable<Type> controllerTypes)
        {
            foreach (var type in controllerTypes)
                services.AddTransient(type);
            return services;
        }
    }
}