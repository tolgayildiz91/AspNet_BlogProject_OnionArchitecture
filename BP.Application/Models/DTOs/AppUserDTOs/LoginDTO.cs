using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Models.DTOs.AppUserDTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adını Boş Geçemezsiniz.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parolayı Boş Geçemezsiniz.")]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
