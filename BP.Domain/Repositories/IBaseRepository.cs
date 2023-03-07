using BP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BP.Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {

        Task Add(T item);
        Task Update(T item);
        //Task Delete(int id);
        Task Delete(T item);
        Task<List<T>> GetDefault(Expression<Func<T, bool>> expression);
        Task<T> GetBy(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();

        Task<bool> Any(Expression<Func<T, bool>> expression);







    }
}
