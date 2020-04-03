using ServiEnvia.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiEnvia.API.Controllers
{
    public class PackageController : ApiController
    {

        private IPackageStatusService _packageStatusService;

        public PackageController(IPackageStatusService packageStatusService)
        {
            _packageStatusService = packageStatusService;
        }
    }
}
