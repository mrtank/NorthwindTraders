namespace Northwind.Application.Customers.Commands.CreateCustomer
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Interfaces;
    using MediatR;

    public class CreateCustomerCommandHandler : Interfaces.IRequestHandler<CreateCustomerCommand>
    {
        private readonly INorthwindDbContext _context;
        private readonly IMediator _mediator;

        public CreateCustomerCommandHandler(INorthwindDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = new Customer
            {
                CustomerId = request.Id,
                Address = request.Address,
                City = request.City,
                CompanyName = request.CompanyName,
                ContactName = request.ContactName,
                ContactTitle = request.ContactTitle,
                Country = request.Country,
                Fax = request.Fax,
                Phone = request.Phone,
                PostalCode = request.PostalCode
            };

            _context.Customers.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new CustomerCreated { CustomerId = entity.CustomerId }, cancellationToken);
        }
    }
}