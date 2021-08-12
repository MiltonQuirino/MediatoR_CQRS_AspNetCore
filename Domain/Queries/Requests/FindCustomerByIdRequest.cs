using System;
using MediatR;
using Shop.Domain.Queries.Responses;

namespace Shop.Domain.Queries.Requests
{
    public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}