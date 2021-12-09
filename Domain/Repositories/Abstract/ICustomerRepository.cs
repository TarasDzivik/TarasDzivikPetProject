using System.Linq;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetCustomer();
        Customer GetCustomerById(int id);
        Customer GetCustomerByFirstName(string FirstName);
        Customer GetCustomerByLustName(string LustName);
        Customer GetCustomerByEmail(string Email);
        Customer GetCustomerByPhoneNumber(string Phone);
        void SaveCustomer(Customer entity);
        void DeleteCustomer(int id);
    }
}