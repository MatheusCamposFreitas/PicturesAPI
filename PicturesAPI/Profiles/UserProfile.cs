using AutoMapper;
using PicturesAPI.Data.Dtos;
using PicturesAPI.Models;

namespace PicturesAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
