using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Application.Interfaces.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
       
    }
}
