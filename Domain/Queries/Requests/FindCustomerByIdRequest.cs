using System;

namespace Shop.Domain.Queries.Requests
{
    public class FindCustomerByIdRequest
    {
        public Guid Id { get; set; }
    }
}