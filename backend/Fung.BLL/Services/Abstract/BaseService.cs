using AutoMapper;
using Fung.DAL;

namespace Fung.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public BaseService(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}
