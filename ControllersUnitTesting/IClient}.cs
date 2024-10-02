namespace ControllersUnitTesting
{
    public interface IClientService
    {
        public IEnumerable<Client> GetAll();
        public Client GetById(int id);
    }
}
