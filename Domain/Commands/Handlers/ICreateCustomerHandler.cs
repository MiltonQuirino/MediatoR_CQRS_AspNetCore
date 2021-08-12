using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}