using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Application.Interfaces.Repository;
using ProductCatalog.Persistance.Context;
using ProductCatalog.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
            
    }
}
