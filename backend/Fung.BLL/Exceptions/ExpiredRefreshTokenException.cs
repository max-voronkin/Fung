namespace Fung.BLL.Exceptions
{
    public sealed class ExpiredRefreshTokenException : Exception
    {
        public ExpiredRefreshTokenException() : base("Refresh token is expired")
        {

        }
    }
}
