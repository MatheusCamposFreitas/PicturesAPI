using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PicturesAPI.Data;
using PicturesAPI.Data.Dtos;
using PicturesAPI.Models;

namespace PicturesAPI.Services
{
    public class UserServices
    {
        private IMapper _mapper;
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public UserServices(IMapper mapper, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task CreateUser(CreateUserDto dto)
        {
            try
            {
                User user = _mapper.Map<User>(dto);

                IdentityResult userCreated = await _userManager.CreateAsync(user, dto.Password);

            } catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
