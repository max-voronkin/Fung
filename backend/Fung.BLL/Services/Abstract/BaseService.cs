using AutoMapper;
using Fung.DAL;

namespace Fung.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        protected readonly DataContext context;
        protected readonly IMapper mapper;

        public BaseService(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}
