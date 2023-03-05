using BP.Application.Models.DTOs.AppUserDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Services.AppUserServices
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO user);
        Task<SignInResult> Login(LoginDTO user);
        Task Logout();
    }
}
