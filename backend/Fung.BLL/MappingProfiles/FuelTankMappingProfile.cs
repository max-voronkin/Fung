using AutoMapper;
using Fung.COMMON.DTO.FuelTank;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class FuelTankMappingProfile : Profile
    {
        public FuelTankMappingProfile()
        {
            CreateMap<FuelTank, FuelTankDTO>();
            CreateMap<FuelTankDTO, FuelTank>();
            CreateMap<FuelTank, FuelTankInfoDTO>();
            CreateMap<FuelTankCreateDTO, FuelTank>();
        }
    }
}
