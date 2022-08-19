using AutoMapper;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;
using Fung.COMMON.Security;
using Fung.DAL;

namespace Fung.BLL.Services
{
    public class UserService : BaseService
    {
        public UserService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<UserDTO> CreateUser(UserRegisterDTO newUser)
        {
            User user = new User() { Email = newUser.Email };
            var salt = SecurityHelper.GetRandomBytes();

            user.Salt = Convert.ToBase64String(salt);
            user.Password = SecurityHelper.HashPassword(newUser.Password, salt);
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(user);
        }
    }
}
