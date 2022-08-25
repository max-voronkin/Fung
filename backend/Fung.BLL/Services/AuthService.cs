using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.JWT;
using Fung.BLL.Services.Abstract;
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

        public string GenerateAccessToken(int id, string email)
        {
            return jwtFactory.GenerateAccessToken(id, email);           
        }

        public async Task<AuthUserDTO> Autorize(UserLoginDTO loginDTO)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            if (user is null || !SecurityHelper.ValidatePassword(loginDTO.Password, user.Password, user.Salt))
            {
                throw new InvalidLoginCredentialsException();
            }

            var accessToken = GenerateAccessToken(user.Id, user.Email);
            var refreshToken = jwtFactory.GenerateRefreshToken();

            return new AuthUserDTO
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

        public async Task<AuthUserDTO> RefreshToken(UserRefreshDTO refreshDTO)
        {
            // TODO update for refresh token
            // This should get user from token
            // Find in db refresh token
            // verify that it is not expired
            // generate new access and refresh token
            // put refresh into db

            var userId = jwtFactory.GetUserIdFromToken(refreshDTO.AccessToken, refreshDTO.SigningKey);
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user is null)
            {
                throw new NotFoundException(nameof(User), userId);
            }

            var accessToken = jwtFactory.GenerateAccessToken(user.Id, user.Email);
            var refreshToken = jwtFactory.GenerateRefreshToken();

            return new AuthUserDTO
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

    }
}
