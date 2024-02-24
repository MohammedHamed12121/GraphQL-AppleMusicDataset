using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using appleMusic.Data;
using appleMusic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace appleMusic.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            // display only 10 for now
            return await _context.Set<T>().Take(12).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithIncludeAsync(params Expression<Func<T, object>>[] includeProperaties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach(var includeProperaty in includeProperaties)
            {
                query = query.Include(includeProperaty); 
            }
            return await query.Take(12).AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        
        }

        public async Task<IEnumerable<T>> GetWithConditionAsync(Expression<Func<T,bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }
    }
}