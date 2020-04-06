using ServiEnvia.Data.EF.ConText;
using ServiEnvia.Repositories.Interfaces;
using ServiEnvia.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ServiEnvia.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository _customerRepository;

        public CustomerService (ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public void SaveCustomer(Customer customer)
        {
            customer.RegistrationDate = DateTime.Now;
            _customerRepository.Add(customer, true);
        }

        public void EditCustomer(Customer customer)
        {
            _customerRepository.Detach(customer);
            _customerRepository.Edit(customer, true);
        }

        public void DetachCustomer(Customer customer)
        {
            _customerRepository.Detach(customer);
        } 

        public void DeleteCustomer(Customer customer)
        {
            _customerRepository.Delete(customer, true);
        }

        public Customer GetCustomerById(string id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }
}