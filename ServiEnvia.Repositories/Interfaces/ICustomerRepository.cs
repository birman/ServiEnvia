using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(string id);
    }
}