using System;
using Shop.Domain.Entities;
using Shop.Domain.Queries.Responses;

namespace Shop.Domain.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        FindCustomerByIdResponse GetCustomerById(Guid id);
    }
}