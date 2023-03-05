using BP.Domain.Entities;
using BP.Domain.Enums;
using BP.Domain.Repositories;
using BP.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.RepositoriesConcrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly BlogumDbContext _dbContext;
        protected DbSet<T> _table;
        public BaseRepository(BlogumDbContext blogumDbContext)
        {
            _dbContext = blogumDbContext;
            _table = _dbContext.Set<T>();
        }
        public async Task Add(T item)
        {
            await _table.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<T>> GetDefault(Expression<Func<T, bool>> expression)
        {
            //var sonuc=  await _table.Where(expression).ToListAsync();
            //  return sonuc.Where(x=>x.Status==Status.Active).ToList();
            return await _table.Where(expression).ToListAsync();
        }
        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _table.AnyAsync(expression);
        }
        public async Task Delete(T item)
        {
            item.Status = Status.Deleted;//Oluşturduğun entitynin status propertysinin değerini deleted yap
            await Update(item);
        }

        public async Task<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return await _table.Where(expression).FirstAsync();
        }
        public async Task Update(T item)
        {
            //_table.Update(item);
            _dbContext.Entry<T>(item).State = EntityState.Modified;//Güncelleme Yap
            await _dbContext.SaveChangesAsync();
        }
    }
}
