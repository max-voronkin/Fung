using AutoMapper;
using Fung.COMMON.DTO.RemainingTransaction;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class RemainingTransactionsMappingProfile : Profile
    {
        public RemainingTransactionsMappingProfile()
        {
            CreateMap<RemainingTransactions, RemainingTransactionsDTO>();
            CreateMap<RemainingTransactionsDTO, RemainingTransactions>();
        }
    }
}
