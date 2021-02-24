﻿using DotNet.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DotNet.Web.Entities;
using DotNet.Web.Database;
using System.Linq;

namespace DotNet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyAsyncController : ControllerBase

    {
        private readonly ExchangesDbContext _dbcontext;
        public CompanyAsyncController(ExchangesDbContext context)
        {
            _dbcontext = context;
        }

        [HttpPost]
        [Route("AddNewItem")]
        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var entity = new ItemEntity
            {
                Name = companyModel.Name,
                Description = companyModel.Description,
                IsVisible = companyModel.IsVisible,
            };
            _dbcontext.Items.Add(entity);
            _dbcontext.SaveChanges();
            return Ok();
        }
        public async Task<IActionResult> GetItemsBack()
        {
            var items = _dbcontext.Items.ToList();

            return Ok(items);
        }
    }
}
