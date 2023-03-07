using BP.Application.Models.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Services.AuthorServices
{
    public interface IAuthorService
    {
        Task Create(AuthorCreateDTO authorDTO);
        Task Edit(AuthorUpdateDTO authorDTO);
        Task Remove(int id);
        Task<List<AuthorListDTO>> AllAuthors();
        Task<AuthorUpdateDTO> GetByID(int id);
        Task<bool> IsAuthorExist(string authorName);
    }
}
