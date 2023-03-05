using AutoMapper;
using BP.Application.Models.DTOs.AppUserDTOs;
using BP.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        IMapper _mapper;

        public async Task<SignInResult> Login(LoginDTO user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, false, false);
            return result;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO user)
        {
            //AppUser appUser = new AppUser();
            //appUser.UserName = user.UserName;
            //appUser.Adress = user.Adress;
            //appUser.Email = user.Email;

            AppUser appUser = _mapper.Map <AppUser>(user);

            var result = await _userManager.CreateAsync(appUser);
            if(result.Succeeded)
            {
                await _signInManager.SignInAsync(appUser, isPersistent: false);
            }

            return result;

        }
    }
}
