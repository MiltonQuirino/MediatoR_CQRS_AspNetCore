using System;
using MediatR;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}