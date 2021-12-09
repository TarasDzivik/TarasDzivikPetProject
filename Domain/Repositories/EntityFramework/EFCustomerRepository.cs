using Microsoft.EntityFrameworkCore;
using System.Linq;
using TarasDzivikPetProject.Domain.Entities;
using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain.Repositories.EntityFramework
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;
        public EFCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Customer> GetCustomer()
        {
            return context.Customers;
        }

        public Customer GetCustomerByEmail(string Email)
        {
            return context.Customers.FirstOrDefault(c => c.Email == Email);
        }

        public Customer GetCustomerByFirstName(string FirstName)
        {
            return context.Customers.FirstOrDefault(c => c.FirstName == FirstName);
        }

        public Customer GetCustomerById(int id)
        {
            return context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer GetCustomerByLustName(string LustName)
        {
            return context.Customers.FirstOrDefault(c => c.LustName == LustName);
        }

        public Customer GetCustomerByPhoneNumber(string Phone)
        {
            return context.Customers.FirstOrDefault(c => c.Phone == Phone);
        }

        public void SaveCustomer(Customer entity)
        {
            if (entity.CustomerId == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            context.Customers.Remove(new Customer() { CustomerId = id });
            context.SaveChanges();
        }
    }
}