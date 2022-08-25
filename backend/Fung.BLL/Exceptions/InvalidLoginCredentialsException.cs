namespace Fung.BLL.Exceptions
{
    public sealed class InvalidLoginCredentialsException : Exception
    {
        public InvalidLoginCredentialsException() : base("Invalid username or password")
        {
        }
    }
}
