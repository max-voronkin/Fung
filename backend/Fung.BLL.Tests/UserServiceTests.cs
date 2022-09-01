using Fung.BLL.Services;
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

        [Fact]
        public void Test()
        {
            
        }
    }
}
