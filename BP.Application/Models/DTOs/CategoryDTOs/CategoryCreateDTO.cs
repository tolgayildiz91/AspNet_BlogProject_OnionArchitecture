using BP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Models.DTOs.CategoryDTOs
{
    public class CategoryCreateDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Status Status => Status.Active;
    }
}
