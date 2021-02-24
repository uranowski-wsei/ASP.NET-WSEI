using DotNet.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.Web.Controllers
{
    public class CompanyController : Controller

    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Ajax");
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };

            return View("CompanyAdded", viewModel);
        }
    }
}
