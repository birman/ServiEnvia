using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Base;
using System.Collections.Generic;

namespace ServiEnvia.Repositories.Interfaces
{
    public interface ICustomerRepository: IEFBaseRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(string id);
    }
}