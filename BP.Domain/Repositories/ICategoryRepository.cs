using BP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Domain.Repositories
{
    public interface ICategoryRepository:IBaseRepository<Category>
    {
        Task<List<Category>> DeactiveCategories();
    }
}
