using DotNet.Web.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;

namespace DotNet.Web.ViewComponents
{
    public class ItemsList : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;
        public ItemsList(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items
            .OrderByDescending(x => x.Id).FirstOrDefault();
            return View("Index", latestItem);
        }
    }

}
