namespace Fung.BLL.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string entityName, int id) : base($"Entity {entityName} with id [{id}] was not found.")
        {
        }
        public NotFoundException(string entityName) : base($"Entity {entityName} was not found.")
        {
        }
    }
}
