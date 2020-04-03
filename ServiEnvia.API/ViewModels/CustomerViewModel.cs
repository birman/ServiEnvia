using ServiEnvia.Data.EF.ConText;
using System;
using System.Collections.Generic;

namespace ServiEnvia.API.ViewModels
{
    public class CustomerViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string ResidenceAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}