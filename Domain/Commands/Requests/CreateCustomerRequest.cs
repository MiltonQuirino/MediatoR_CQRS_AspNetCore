using System;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}