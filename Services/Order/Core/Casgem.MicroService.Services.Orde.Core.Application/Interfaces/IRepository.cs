using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateGetAsync(T entity);
        Task<T> UpdateGetAsync(T entity);
        Task<T> DeleteGetAsync(T entity);
        Task<List<T>> GetOrdersById(string UserId);
    }
}
