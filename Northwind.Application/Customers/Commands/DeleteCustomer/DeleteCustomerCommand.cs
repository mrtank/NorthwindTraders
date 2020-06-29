namespace Northwind.Application.Customers.Commands.DeleteCustomer
{
    using Interfaces;

    public class DeleteCustomerCommand : IRequest
    {
        public string Id { get; set; }
    }
}
