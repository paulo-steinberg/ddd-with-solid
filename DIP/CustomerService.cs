using Solid.Contracts;

namespace Solid
{
    public class CustomerService : ICustomerRepository
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Save(string name)
        {
            _repository.Save(name);
        }
    }
}