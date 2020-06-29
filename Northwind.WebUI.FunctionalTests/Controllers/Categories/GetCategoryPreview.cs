using System.Net.Http;
using System.Threading.Tasks;
using Northwind.Application.Categories.Models;
using Northwind.WebUI.FunctionalTests.Common;
using Xunit;

namespace Northwind.WebUI.FunctionalTests.Controllers.Categories
{
    public class GetCategoryPreview : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public GetCategoryPreview(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsCategoryPreviewDto()
        {
            var categoryId = 1;

            var response = await _client.GetAsync($"/api/categories/getcategorypreview/{categoryId}");

            response.EnsureSuccessStatusCode();

            var category = await Utilities.GetResponseContent<CategoryPreviewDto>(response);

            Assert.Equal(categoryId, category.CategoryId);
        }
    }
}
