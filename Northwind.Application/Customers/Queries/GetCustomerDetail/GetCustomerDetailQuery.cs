
namespace Northwind.Application.Customers.Queries.GetCustomerDetail
{
    using Interfaces;

    public class GetCustomerDetailQuery : IRequest<CustomerDetailModel>
    {
        public string Id { get; set; }
    }
}
