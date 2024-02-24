using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace appleMusic.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetWithConditionAsync(Expression<Func<T,bool>> expression);
    }
}