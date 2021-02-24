using DotNet.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyAsyncController : ControllerBase

    {
        [HttpPost]
        [Route("AddNewItem")]
        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var companyAddedModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = companyModel.Name.Length,
                NumberOfCharsInDescription = companyModel.Description.Length,
                IsHidden = !companyModel.IsVisible
            };
            return Ok(companyAddedModel);
        }
    }
}
