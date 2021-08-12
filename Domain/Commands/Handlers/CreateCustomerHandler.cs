using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Domain.Services;

namespace Shop.Domain.Handlers
{
    // public class CreateCustomerHandler : ICreateCustomerHandler

    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        ICustomerRepository _repository;
        IEmailService _emailService;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Aplicar Fail Fast Validations

            // Cria a entidade
            var customer = new Customer(request.Name, request.Email);

            // Persiste a entidade no banco
            _repository.Save(customer);

            // Envia E-mail de boas-vindas
            _emailService.Send(customer.Name, customer.Email);

            // Retorna a resposta
            var result = new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}