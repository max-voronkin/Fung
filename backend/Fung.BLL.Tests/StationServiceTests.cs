using Fung.BLL.Exceptions;
using Fung.BLL.Services;
using Fung.COMMON.DTO.Station;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Fung.BLL.Tests
{
    public class StationServiceTests : BaseTest
    {
        private readonly StationService stationService;
        private readonly DataContext context;

        public StationServiceTests()
        {
            context = new DataContext(dbContextOptions);
            stationService = new StationService(context, mapper);
        }

        #region GetStations
        [Fact]
        public async Task GetStations_WhenThereIsNoStations_ThenResultCountZero()
        {
            var result = await stationService.GetStationsAsync(1);
            Assert.True(result.Count == 0);
        }

        [Fact]
        public async Task GetStations_WhenThereIsOneStation_ThenResultCountOne()
        {
            var station = await CreateStationAsync();

            var result = await stationService.GetStationsAsync(station.UserId);
            Assert.True(result.Count == 1);
        }
        #endregion

        #region GetStation
        [Fact]
        public async Task GetStation_WhenThereIsNoStation_ThenThrowsNotFoundException()
        {
            await Assert.ThrowsAsync<NotFoundException>(() => stationService.GetStationAsync(1));
        }

        [Fact]
        public async Task GetStation_WhenThereIsOneStation_ThenResultCountOne()
        {
            var station = await CreateStationAsync();

            var result = await stationService.GetStationsAsync(station.UserId);
            Assert.True(result.Count == 1);
        }
        #endregion

        #region CreateStation

        [Fact]
        public async Task CreateStation_WhenDataCorrect_ThenReturnsStation()
        {
            var newStationDTO = new StationCreateDTO()
            {
                Name = "Test",
                UserId = 1
            };

            var result = await stationService.CreateStationAsync(newStationDTO);

            Assert.NotNull(result);
            Assert.Equal(newStationDTO.Name, result.Name);
        }
        #endregion

        #region DeleteStation

        [Fact]
        public async Task DeleteStation_WhenStationExist_ThenStationRemovedFromStationsaTable()
        {
            var station = await CreateStationAsync();

            await stationService.DeleteStationAsync(station.Id);

            var result = await context.Stations.FirstOrDefaultAsync(s => s.Id == station.Id);
            Assert.Null(result);
        }

        [Fact]
        public async Task DeleteStation_WhenStationDoesNotExist_ThenThrowsNotFoundException()
        {
            await Assert.ThrowsAsync<NotFoundException>(() => stationService.DeleteStationAsync(1));
        }
        #endregion

        #region Helpers
        private async Task<Station> CreateStationAsync()
        {
            var station = new Station()
            {
                Name = "Test Station",
                Token = "Token",
                UserId = 1
            };
            context.Stations.Add(station);
            await context.SaveChangesAsync();
            return station;
        }
        #endregion
    }
}
