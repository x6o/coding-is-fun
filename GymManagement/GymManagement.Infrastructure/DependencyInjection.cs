using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Infrastructure.Common.Persistence;
using GymManagement.Infrastructure.Subscriptions.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure (this IServiceCollection services)
        {
            services.AddDbContext<GymManagementDbContext>(options => 
                    options.UseSqlite("Data Source = GymManagement.db"));
            services.AddScoped<ISubscriptionsRepository, SubscriptionsRepository>();

            return services;
        }
    }
}
