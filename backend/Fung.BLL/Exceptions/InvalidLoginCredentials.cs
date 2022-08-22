namespace Fung.BLL.Exceptions
{
    public sealed class InvalidLoginCredentials : Exception
    {
        public InvalidLoginCredentials() : base("Invalid username or password")
        {
        }
    }
}
