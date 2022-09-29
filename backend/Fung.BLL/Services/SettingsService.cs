using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.Settings;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class SettingsService : BaseService
    {
        public SettingsService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<SettingsDTO> GetSettingsByIdAsync(int id)
        {
            var settings = await context.Settings.FirstOrDefaultAsync(s => s.UserId == id);
            if (settings is null)
            {
                throw new NotFoundException(nameof(Settings));
            }

            return mapper.Map<SettingsDTO>(settings);
        }

        public async Task<SettingsDTO> UpdateSettingsAsync(UpdateSettingsDTO settingsDTO)
        {
            var settings = await context.Settings.FirstOrDefaultAsync(s => s.Id == settingsDTO.Id);
            if (settings is null)
            {
                throw new NotFoundException(nameof(Settings), settingsDTO.Id);
            }

            settings.HeightUnit = settingsDTO.HeightUnit;
            settings.VolumeUnit = settingsDTO.VolumeUnit;

            await context.SaveChangesAsync();
            return mapper.Map<SettingsDTO>(settings);
        }
    }
}
