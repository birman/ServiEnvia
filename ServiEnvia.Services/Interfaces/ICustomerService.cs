using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(string id);

        void SaveCustomer(Customer customer);

        void EditCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        void DetachCustomer(Customer customer);
    }
}