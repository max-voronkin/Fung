namespace Fung.BLL.Exceptions
{
    public class InvalidTokenException : Exception
    {
        public InvalidTokenException() : base("Invalid Token or Key")
        {
        }

        public InvalidTokenException(string message) : base(message)
        {

        }
    }
}
