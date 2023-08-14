using Casgem.MicroService.Services.Orde.Core.Application.Interfaces;


using CasgemMicroService.Services.Order.Infrastructure.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Infra.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OrderContext _context;

        public Repository(OrderContext context)
        {
            _context = context;
        }

        public async Task<T> CreateGetAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        

        public async Task<T> DeleteGetAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task<List<T>> GetOrdersById(string UserId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetOrdersById(Expression<Func<T, bool>> filter = null)
        {


            return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T> UpdateGetAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}