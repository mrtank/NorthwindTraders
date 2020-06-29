
namespace Northwind.Application.Products.Commands.DeleteProduct
{
    using Interfaces;

    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }
    }
}
