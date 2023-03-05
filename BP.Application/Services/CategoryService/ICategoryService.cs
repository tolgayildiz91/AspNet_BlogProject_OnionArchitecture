using BP.Application.Models.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        Task Create(CategoryCreateDTO categoryDTO);
        Task Edit(CategoryUpdateDTO categoryDTO);
        Task Remove(int id);
        Task<List<CategoryListDTO>> AllCategories();
        Task<CategoryUpdateDTO> GetByID(int id);
        Task<bool> IsCategoryExist(string categoryName);


    }
}
