using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.WebUI.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Interfaces;

    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        public async Task<TResponse> Send<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = new CancellationToken())
            where TRequest : IRequest<TResponse>
        {
            return await HttpContext
                .RequestServices
                .GetService<IRequestHandler<TRequest, TResponse>>()
                .Handle(request, cancellationToken);
        }

        public async Task Send<TRequest>(TRequest request,
            CancellationToken cancellationToken = new CancellationToken())
            where TRequest: IRequest
        {
            await HttpContext
                .RequestServices
                .GetService<IRequestHandler<TRequest>>()
                .Handle(request, cancellationToken);
        }
    }
}
