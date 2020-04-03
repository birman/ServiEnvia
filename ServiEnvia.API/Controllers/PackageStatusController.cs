using ServiEnvia.API.Extended;
using ServiEnvia.API.ViewModels;
using ServiEnvia.Services.Interfaces;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace ServiEnvia.API.Controllers
{
    public class PackageStatusController : ApiController
    {
        private IPackageStatusService _PackageStatusService;

        public PackageStatusController(IPackageStatusService PackageStatusService)
        {
            _PackageStatusService = PackageStatusService;
        }

        // GET: api/PackageStatus
        [ResponseType(typeof(PackageStatusViewModel))]
        public IHttpActionResult GetPackageStatus()
        {
            return Ok(_PackageStatusService.GetAllPackageStatus().EntityToModel());
        }

        // GET: api/PackageStatus/5
        [ResponseType(typeof(PackageStatusViewModel))]
        public IHttpActionResult GetPackageStatus(int id)
        {
            PackageStatusViewModel PackageStatus = _PackageStatusService.GetPackageStatusById(id).EntityToModel();
            if (PackageStatus == null)
            {
                return Content(HttpStatusCode.BadRequest, "Estado paquete no existe");
            }

            return Ok(PackageStatus);
        }
    }
}