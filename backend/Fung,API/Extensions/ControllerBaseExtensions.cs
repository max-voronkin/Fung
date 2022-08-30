using Fung.BLL.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static int GetUserIdFromToken(this ControllerBase controller)
        {
            var claimsUserId = controller.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;

            if (string.IsNullOrEmpty(claimsUserId))
            {
                throw new InvalidTokenException("GetUserIdFromToken Can`t get Id");
            }

            return int.Parse(claimsUserId);
        }
    }
}
