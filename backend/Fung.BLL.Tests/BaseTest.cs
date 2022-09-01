using AutoMapper;
using Fung.BLL.MappingProfiles;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Tests
{
    public class BaseTest
    {
        protected IMapper mapper = new Mapper(mapperConfig);

        private static IConfigurationProvider mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<FuelTankMappingProfile>();
            cfg.AddProfile<LevelIndicatorMappingProfile>();
            cfg.AddProfile<UserMappingProfile>();
            cfg.AddProfile<RemainingTransactionsMappingProfile>();
            cfg.AddProfile<StationMappingProfile>();
        });

        protected DbContextOptions<DataContext> dbContextOptions = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase("TestingDB")
            .Options;
    }
}
