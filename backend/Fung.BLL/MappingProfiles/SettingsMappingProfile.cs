using AutoMapper;
using Fung.COMMON.DTO.Settings;
using Fung.COMMON.Entities;

namespace Fung.BLL.MappingProfiles
{
    public class SettingsMappingProfile : Profile
    {
        public SettingsMappingProfile()
        {
            CreateMap<Settings, SettingsDTO>();
        }
    }
}
