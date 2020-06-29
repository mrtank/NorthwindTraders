namespace Northwind.Application.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRequestHandler<in TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request, CancellationToken cancellation);
    }

    public interface IRequestHandler<in TRequest>
        where TRequest : IRequest
    {
        Task Handle(TRequest request, CancellationToken cancellation);
    }
}