using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCatalog.Application.Interfaces.Repository;
using ProductCatalog.Domain.Entities;
using ProductCatalog.Persistance.Context;

namespace ProductCatalog.Persistance.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
        {
         
        }
    }
}
