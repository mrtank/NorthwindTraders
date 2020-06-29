using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Categories.Models;
using Northwind.Application.Categories.Queries;

namespace Northwind.WebUI.Controllers
{
    public class CategoriesController : BaseController
    {
        [HttpGet("{categoryId}")]
        [ProducesResponseType(typeof(CategoryPreviewDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCategoryPreview(int categoryId)
        {
            return Ok(await Send<GetCategoryPreviewQuery, CategoryPreviewDto>(new GetCategoryPreviewQuery {CategoryId = categoryId}));
        }
    }
}
