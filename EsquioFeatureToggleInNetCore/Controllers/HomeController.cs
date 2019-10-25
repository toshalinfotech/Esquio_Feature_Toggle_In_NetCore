using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Esquio.AspNetCore.Endpoints.Metadata;

namespace EsquioFeatureToggleInNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [FeatureFilter(Names = FeatureFlags.SeeDetails)]
        public IActionResult SeeData()
        {
            return View();
        }


        [FeatureFilter(Names = FeatureFlags.SeeHostDetails)]
        public IActionResult SeeHostDetails()
        {
            return View();
        }

        [FeatureFilter(Names = FeatureFlags.SeeAdminDetails)]
        public IActionResult SeeAdminDetails()
        {
            return View();
        }

    }
}
