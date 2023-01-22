using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC6._0.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]

    public class DashboardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}