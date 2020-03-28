using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using ServiEnvia.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ServiEnvia.Repositories.Implementations
{
    public class CustomerRepository : EFBaseRepository, ICustomerRepository
    {
        public CustomerRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customer;
        }

        public Customer GetCustomerById(string id)
        {
            return _context.Customer.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}