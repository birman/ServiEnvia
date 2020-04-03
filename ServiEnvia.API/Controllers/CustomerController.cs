using ServiEnvia.API.Extended;
using ServiEnvia.API.ViewModels;
using ServiEnvia.Services.Interfaces;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace ServiEnvia.API.Controllers
{
    public class CustomerController : ApiController
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [ResponseType(typeof(CustomerViewModel))]
        public IHttpActionResult GetCustomer()
        {
            return Ok(_customerService.GetCustomers().EntityToModel());
        }

        // GET: api/Customer/5
        [ResponseType(typeof(CustomerViewModel))]
        public IHttpActionResult GetCustomer(string id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return Content(HttpStatusCode.BadRequest, "Cliente no existe");
            }

            return Ok(customer.EntityToModel());
        }

        // PUT: api/Customer/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(string id, CustomerViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.Id)
            {
                return Content(HttpStatusCode.BadRequest, "Cliente no coinciden");
            }

            var _customer = _customerService.GetCustomerById(id);

            if (_customer == null)
            {
                return Content(HttpStatusCode.BadRequest, "Cliente no existe");
            }
            else
            {
                _customerService.DetachCustomer(_customer);
                _customerService.EditCustomer(customer.ModelToEntity());
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Customer
        [ResponseType(typeof(CustomerViewModel))]
        public IHttpActionResult PostCustomer(CustomerViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _customer = _customerService.GetCustomerById(customer.Id);

            if (_customer == null)
            {
                _customerService.SaveCustomer(customer.ModelToEntity());
                return Ok(customer);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, "Cliente ya existe");
            }
        }

        // DELETE: api/Customer/5
        [ResponseType(typeof(CustomerViewModel))]
        public IHttpActionResult DeleteCliente(string id)
        {
            var _customer = _customerService.GetCustomerById(id);

            if (_customer == null)
            {
                return Content(HttpStatusCode.BadRequest, "Cliente no existe");
            }
            else
            {
                _customerService.DeleteCustomer(_customer);
                return Ok(_customer.EntityToModel());
            }
        }
    }
}