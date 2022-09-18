using AutoMapper;
using Fung.COMMON.DTO.LevelIndicator;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class LevelIndicatorMappingProfile : Profile
    {
        public LevelIndicatorMappingProfile()
        {
            CreateMap<LevelIndicatorTransactions, LevelIndicatorTransactionDTO>();
            CreateMap<LevelIndicatorTransactionDTO, LevelIndicatorTransactions>();
            CreateMap<LevelIndicatorTransactionCreateDTO, LevelIndicatorTransactions>();
        }
    }
}
