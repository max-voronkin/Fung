using AutoMapper;
using Fung.BLL.Services.Abstract;
using Fung.DAL;

namespace Fung.BLL.Services
{
    public class AuthService : BaseService
    {
        public AuthService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
