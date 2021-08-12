using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using Shop.Domain.Repositories;

namespace Shop.Domain.Commands.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            return _repository.GetCustomerById(command.Id);
        }
    }
}