﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tammU.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);
    }
}
