using System;
using Shop.Domain.Entities;
using Shop.Domain.Queries.Responses;

namespace Shop.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public FindCustomerByIdResponse GetCustomerById(Guid id)
        {
            return new FindCustomerByIdResponse(Guid.NewGuid(), "Milton", "milton@me.com");
        }

        public void Save(Customer customer)
        {
            // throw new NotImplementedException();
        }
    }
}