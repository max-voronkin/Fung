using Fung.BLL.Exceptions;
using Fung.BLL.Services;
using Fung.COMMON.DTO.User;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Fung.BLL.Tests
{
    public class UserServiceTests : BaseTest
    {
        private readonly UserService userService;
        private readonly DataContext context;
        public UserServiceTests()
        {
            context = new DataContext(dbContextOptions);
            userService = new UserService(context, mapper);
        }

        #region CreateUser
        [Fact]
        public async Task CreateUser_WhenNewUser_ThenUsersCountOne()
        {
            var newUser = new UserRegisterDTO()
            {
                Email = "test@gmail.com",
                Password = "StrongPassword"
            };

            var createdUser = await userService.CreateUser(newUser);
            Assert.NotNull(createdUser);

            Assert.True(context.Users.ToList().Count == 1, $"Expected 1 user, but was {context.Users.ToList().Count}");
        }

        [Fact]
        public async Task CreateUser_WhenEmailAlreadyTaken_ThenUserAlreadyExistsExceptionThrown()
        {
            var newUser = new UserRegisterDTO()
            {
                Email = "test@gmail.com",
                Password = "StrongPassword"
            };
            await userService.CreateUser(newUser);

            await Assert.ThrowsAsync<UserAlreadyExistsException>(() => userService.CreateUser(newUser));
        }
        #endregion

        #region GetUserById
        [Fact]
        public async Task GetUserById_WhenUserExist_ThenUsersCountOne()
        {
            var user = new User()
            {
                CreatedAt = DateTime.UtcNow,
                Email = "test@user.com",
                IsEmailConfirmed = false,
                Password = "password",
                Salt = "salt"
            };
            context.Users.Add(user);
            await context.SaveChangesAsync();

            var returnedUser = await userService.GetUserByIdAsync(user.Id);
            Assert.NotNull(returnedUser);
        }
        [Fact]
        public async Task GetUserById_WhenUserDontExist_TheNotFoundExceptionThrown()
        {
            await Assert.ThrowsAsync<NotFoundException>(() => userService.GetUserByIdAsync(1));
        }
        #endregion
    }
}
