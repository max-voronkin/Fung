using AutoMapper;
using Fung.COMMON.DTO.Station;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class StationMappingProfile : Profile
    {
        public StationMappingProfile()
        {
            CreateMap<Station, StationDTO>();
            CreateMap<StationDTO, Station>();
        }
    }
}
