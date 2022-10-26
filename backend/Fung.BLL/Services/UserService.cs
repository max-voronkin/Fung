using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;
using Fung.COMMON.Security;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class UserService : BaseService
    {
        public UserService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<UserDTO> CreateUserAsync(UserRegisterDTO newUser)
        {
            if (await context.Users.FirstOrDefaultAsync(u => u.Email == newUser.Email) is not null)
            {
                throw new UserAlreadyExistsException();
            }

            User user = new User() { Email = newUser.Email };
            var salt = SecurityHelper.GetRandomBytes();

            user.Salt = Convert.ToBase64String(salt);
            user.Password = SecurityHelper.HashPassword(newUser.Password, salt);
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            var settings = new Settings(user.Id);
            await context.Settings.AddAsync(settings);

            await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user is null)
            {
                throw new NotFoundException(nameof(User), id);
            }

            return mapper.Map<UserDTO>(user);
        }

        public async Task ChangeUserPasswordAsync(UserChangePasswordDTO dto, int userId)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (!SecurityHelper.ValidatePassword(dto.Password, user!.Password, user.Salt))
            {
                throw new InvalidLoginCredentialsException();
            }
            var salt = SecurityHelper.GetRandomBytes();
            user.Salt = Convert.ToBase64String(salt);
            user.Password = SecurityHelper.HashPassword(dto.NewPassword, salt);

            await context.SaveChangesAsync();    
        }
    }
}
