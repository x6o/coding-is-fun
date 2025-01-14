﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(opts =>
            {
                opts.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
            });

            return services;
        } 
    }
}
