namespace Fung.BLL.Exceptions
{
    public sealed class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException() : base("This user already exist")
        {

        }
    }
}
