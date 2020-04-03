using ServiEnvia.API.ViewModels;
using ServiEnvia.Data.EF.ConText;
using System.Collections.Generic;

namespace ServiEnvia.API.Extended
{
    public static class CustomerExtended
    {
        public static CustomerViewModel EntityToModel(this Customer customer)
        {
            return new CustomerViewModel
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                BirthDate = customer.BirthDate,
                ResidenceAddress = customer.ResidenceAddress,
                Phone = customer.Phone,
                Email = customer.Email,
                RegistrationDate = customer.RegistrationDate,
                Status = customer.Status,
                //Package = customer.Package
            };
        }

        public static IEnumerable<CustomerViewModel> EntityToModel(this IEnumerable<Customer> listCustomer)
        {
            if (listCustomer == null) yield return null;
            else
                foreach (var item in listCustomer)
                {
                    yield return EntityToModel(item);
                }
        }

        public static Customer ModelToEntity(this CustomerViewModel customer)
        {
            return new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                BirthDate = customer.BirthDate,
                ResidenceAddress = customer.ResidenceAddress,
                Phone = customer.Phone,
                Email = customer.Email,
                RegistrationDate = customer.RegistrationDate,
                Status = customer.Status
            };
        }

        public static IEnumerable<Customer> ModelToEntity(this IEnumerable<CustomerViewModel> listCustomerViewModels)
        {
            if (listCustomerViewModels == null) yield return null;
            else
                foreach (var item in listCustomerViewModels)
                {
                    yield return ModelToEntity(item);
                }
        }
    }
}