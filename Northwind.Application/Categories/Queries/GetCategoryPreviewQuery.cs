using Northwind.Application.Categories.Models;

namespace Northwind.Application.Categories.Queries
{
    using Interfaces;

    public class GetCategoryPreviewQuery : IRequest<CategoryPreviewDto>
    {
        public int CategoryId { get; set; }
    }
}
