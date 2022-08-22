using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.JWT;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.Auth;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;
using Fung.COMMON.Security;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class AuthService : BaseService
    {
        private readonly JwtFactory jwtFactory;
        public AuthService(DataContext context, IMapper mapper, JwtFactory jwtFactory) : base(context, mapper)
        {
            this.jwtFactory = jwtFactory;
        }

        public AuthTokenDTO GenerateAccessToken(int id, string email)
        {
            var token = jwtFactory.GenerateAccessToken(id, email);
            return new AuthTokenDTO() { Token = token };
        }

        public async Task<AuthUserDTO> Autorize(UserLoginDTO loginDTO)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            if (user is null)
            {
                throw new NotFoundException(nameof(User));
            }

            if (!SecurityHelper.ValidatePassword(loginDTO.Password, user.Password, user.Salt))
            {
                throw new InvalidLoginCredentials();
            }

            var token = GenerateAccessToken(user.Id, user.Email);
            var userDTO = mapper.Map<UserDTO>(user);

            return new AuthUserDTO
            {
                User = userDTO,
                Token = token
            };
        }

    }
}
