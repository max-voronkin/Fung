using AutoMapper;
using Fung.BLL.JWT;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.Auth;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;
using Fung.COMMON.Security;
using Fung.DAL;

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

    }
}
