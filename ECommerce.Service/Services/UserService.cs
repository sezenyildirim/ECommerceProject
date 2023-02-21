using ECommerce.Application.Services;
using ECommerce.Entity.DTOS;
using ECommerce.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;//usermanager identity'den geliyor, user işlemlerini yapmamızı sağlıyor

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task CreateUser(RegisterDTO registerDTO)
        {
            AppUser user = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = registerDTO.UserName,
                Email = registerDTO.Email,

            };
         IdentityResult result = await  _userManager.CreateAsync(user, registerDTO.Password);
        }
    }
}
