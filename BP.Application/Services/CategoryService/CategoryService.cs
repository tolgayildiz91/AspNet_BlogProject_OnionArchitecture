using AutoMapper;
using BP.Application.Models.DTOs.CategoryDTOs;
using BP.Domain.Entities;
using BP.Domain.Enums;
using BP.Domain.Repositories;
using BP.Infrastructure.RepositoriesConcrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<List<CategoryListDTO>> AllCategories()
        {

            
            var listCategories =  _mapper.Map<List<CategoryListDTO>>(await _categoryRepository.GetAll());
            return listCategories;
            
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

        public async Task<CategoryUpdateDTO> GetByID(int id)
        {

            var category = _mapper.Map<CategoryUpdateDTO>(_categoryRepository.GetBy(x => x.Id == id));
            return category;
         
        }

        public Task<bool> IsCategoryExist(string categoryName)
        {
            return _categoryRepository.Any(x => x.Name == categoryName);
        }

        public async Task Remove(int id)
        {
            var category = await _categoryRepository.GetBy(x=>x.Id==id);
            await _categoryRepository.Delete(category);
        }
    }
}
