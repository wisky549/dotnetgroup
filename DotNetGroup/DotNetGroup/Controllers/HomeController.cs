using DNG.Business;
using DotNetGroup.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetGroup.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(QueryBusiness queryBusiness)
        {
            _query = queryBusiness;
        }

        QueryBusiness _query;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
