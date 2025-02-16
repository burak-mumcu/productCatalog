using ProductCatalog.Domain.Common;
using ProductCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);
    }
}
