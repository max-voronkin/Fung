﻿using AutoMapper;
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
        private readonly UserService userService;
        public AuthService(DataContext context, IMapper mapper, JwtFactory jwtFactory, UserService userService) : base(context, mapper)
        {
            this.jwtFactory = jwtFactory;
            this.userService = userService;
        }

        public AuthUserDTO GenerateAccessToken(int id, string email)
        {
            return new AuthUserDTO
            {
                AccessToken = jwtFactory.GenerateAccessToken(id, email),
                RefreshToken = jwtFactory.GenerateRefreshToken()
            };
        }

        public async Task<AuthUserDTO> Autorize(UserLoginDTO loginDTO)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            if (user is null || !SecurityHelper.ValidatePassword(loginDTO.Password, user.Password, user.Salt))
            {
                throw new InvalidLoginCredentialsException();
            }

            AuthUserDTO authUser = GenerateAccessToken(user.Id, user.Email);
            var refreshToken = await context.RefreshTokens.FirstOrDefaultAsync(t => t.UserId == user.Id);
            if (refreshToken is not null)
            {
                context.RefreshTokens.Remove(refreshToken);
            }
            context.RefreshTokens.Add(new RefreshToken
            {
                Token = authUser.RefreshToken,
                UserId = user.Id
            });
            await context.SaveChangesAsync();

            return authUser;
        }

        public async Task<AuthUserDTO> RefreshToken(UserRefreshDTO refreshDTO)
        {
            var userId = jwtFactory.GetUserIdFromToken(refreshDTO.AccessToken, refreshDTO.SigningKey);
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user is null)
            {
                throw new NotFoundException(nameof(User), userId);
            }

            var rToken = await context.RefreshTokens.FirstOrDefaultAsync(t => t.Token == refreshDTO.RefreshToken);
            if (rToken is null)
            {
                throw new InvalidTokenException("Invalid refresh token");
            }

            if (!rToken.IsActive)
            {
                throw new ExpiredRefreshTokenException();
            }

            var accessToken = jwtFactory.GenerateAccessToken(user.Id, user.Email);
            var refreshToken = jwtFactory.GenerateRefreshToken();

            context.RefreshTokens.Remove(rToken);
            context.RefreshTokens.Add(new RefreshToken
            {
                Token = refreshToken,
                UserId = user.Id
            });
            await context.SaveChangesAsync();

            return new AuthUserDTO
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

        public async Task<AuthUserDTO> Register(UserRegisterDTO registerDTO)
        {
            var createdUser = await userService.CreateUser(registerDTO);
            AuthUserDTO userTokens = GenerateAccessToken(createdUser.Id, createdUser.Email);

            var s = new RefreshToken()
            {
                UserId = createdUser.Id,
                Token = userTokens.RefreshToken
            };

            context.RefreshTokens.Add(s);
            await context.SaveChangesAsync();
            return userTokens;
        }

        public async Task RevokeToken(UserRevokeDTO token)
        {
            var tokenEntity = await context.RefreshTokens.FirstOrDefaultAsync(t => t.Token == token.RefreshToken);
            if (tokenEntity is not null)
            {
                context.RefreshTokens.Remove(tokenEntity);
                await context.SaveChangesAsync();
            }
        }

    }
}
