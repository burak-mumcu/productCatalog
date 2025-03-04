﻿using Microsoft.EntityFrameworkCore;
using ProductCatalog.Application.Interfaces.Repository;
using ProductCatalog.Domain.Common;
using ProductCatalog.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await dbContext.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await dbContext.Set<T>().FindAsync(Id);
        }
    }
}
