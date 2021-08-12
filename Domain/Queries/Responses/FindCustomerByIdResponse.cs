using System;

namespace Shop.Domain.Queries.Responses
{
    public class FindCustomerByIdResponse
    {
        public FindCustomerByIdResponse(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}