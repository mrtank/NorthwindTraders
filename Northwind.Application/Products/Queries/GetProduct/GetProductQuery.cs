
namespace Northwind.Application.Products.Queries.GetProduct
{
    using Interfaces;

    public class GetProductQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
    }
}
