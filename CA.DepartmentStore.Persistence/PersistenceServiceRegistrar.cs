using CA.DepartmentStore.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Persistence
{
    public static class PersistenceServiceRegistrar
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DepartmentStoreDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DepartmentStoreConnectionString")));


            return services;
        }
    }
}
