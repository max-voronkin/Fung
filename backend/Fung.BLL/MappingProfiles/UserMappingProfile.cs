using AutoMapper;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
