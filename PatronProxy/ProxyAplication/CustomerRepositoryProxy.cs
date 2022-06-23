using PatronProxy;

namespace ProxyAplication
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository? _repository;

        public IList<Customer> GetAll()
        {
            if (_repository == null) _repository = new CustomerRepository();

            if (Session.CanGetAll)
            {
                return _repository.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(Customer customer)
        {
            if (_repository == null) _repository = new CustomerRepository();

            if (Session.CanSave)
            {
                _repository.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}