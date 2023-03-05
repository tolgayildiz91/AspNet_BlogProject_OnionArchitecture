using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Models.DTOs.AppUserDTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adını Boş Geçemezsiniz.")]
        [Display(Name = "Kullanıcı Adı")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Parolayı Boş Geçemezsiniz.")]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Parola Tekrarını Boş Geçemezsiniz.")]
        [Display(Name = "ParolaTekrar")]
        [Compare("Password", ErrorMessage = "Parolalar Uyumsuz")]
        [DataType(DataType.Password)]
        public string ConfirmPassowrd { get; set; }


        [Required(ErrorMessage = "Emaili Boş Geçemezsiniz.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Adres")]
        public string Adress { get; set; }
    }
}
