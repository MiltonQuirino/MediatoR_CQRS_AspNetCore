using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using Shop.Domain.Repositories;

namespace Shop.Domain.Commands.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCustomerById(request.Id);
            return Task.FromResult(result);
        }
    }
}