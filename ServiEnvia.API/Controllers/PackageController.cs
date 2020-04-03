using ServiEnvia.API.Extended;
using ServiEnvia.API.ViewModels;
using ServiEnvia.Services.Interfaces;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace ServiEnvia.API.Controllers
{
    public class PackageController : ApiController
    {
        private IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        // GET: api/Package
        [ResponseType(typeof(PackageViewModel))]
        public IHttpActionResult GetPackage()
        {
            return Ok(_packageService.GetPackages().EntityToModel());
        }

        // GET: api/Package/5
        [ResponseType(typeof(PackageViewModel))]
        public IHttpActionResult GetPackage(long id)
        {
            var Package = _packageService.GetPackageByGuideId(id);
            if (Package == null)
            {
                return Content(HttpStatusCode.BadRequest, "Paquete no existe");
            }

            return Ok(Package.EntityToModel());
        }

        // PUT: api/Package/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPackage(long id, PackageViewModel Package)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Package.GuideId)
            {
                return Content(HttpStatusCode.BadRequest, "Paquete no coinciden");
            }

            var _Package = _packageService.GetPackageByGuideId(id);

            if (_Package == null)
            {
                return Content(HttpStatusCode.BadRequest, "Paquete no existe");
            }
            else
            {
                _packageService.DetachPackage(_Package);
                _packageService.EditPackage(Package.ModelToEntity());
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Package
        [ResponseType(typeof(PackageViewModel))]
        public IHttpActionResult PostPackage(PackageViewModel package)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _package = _packageService.GetPackageByGuideId(package.GuideId);

            if (_package == null)
            {
                _packageService.SavePackage(package.ModelToEntity());
                return Ok(package);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, "Paquete ya existe");
            }
        }

        // DELETE: api/Package/5
        [ResponseType(typeof(PackageViewModel))]
        public IHttpActionResult DeletePaquete(long id)
        {
            var _Package = _packageService.GetPackageByGuideId(id);

            if (_Package == null)
            {
                return Content(HttpStatusCode.BadRequest, "Paquete no existe");
            }
            else
            {
                _packageService.DeletePackage(_Package);
                return Ok(_Package.EntityToModel());
            }
        }
    }
}