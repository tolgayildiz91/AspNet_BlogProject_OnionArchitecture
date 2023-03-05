using AutoMapper;
using BP.Application.Models.DTOs.CategoryDTOs;
using BP.Domain.Entities;
using BP.Domain.Repositories;
using BP.Infrastructure.RepositoriesConcrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public Task<List<CategoryListDTO>> AllCategories()
        {
            throw new NotImplementedException();
        }

        public async Task Create(CategoryCreateDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Add(category);
        }

        public async Task Edit(CategoryUpdateDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Update(category);
        }

        public Task<CategoryUpdateDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsCategoryExist(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
