using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class CustomerRepository(ApplicationDbContext context) : ICustomer
    {
        public async Task<int> AddAsync(Customer entity)
        {
            try
            {
                context.Set<Customer>().Add(entity);
                return await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                //Check if email already exist
                var result = await context.Customers.Where(x => x.Email.ToLower().Equals(entity.Email.ToLower())).FirstOrDefaultAsync();
                if (result != null)
                {
                    throw new ItemNotFoundException($"Item {typeof(Customer).Name} with {result.Email} already exists");
                }
                else { throw; }
            }

        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<Customer>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(Customer).Name} with {id} is not found");
            }
            context.Set<Customer>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(Customer entity)
        {
            context.Set<Customer>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            var result = await context.Customers.FindAsync(id);
            return result!;
        }
        public async Task<Customer?> GetByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return null;
            }
            var result = await context.Customers.Where(x => x.Email.ToLower().Equals(email.ToLower())).FirstOrDefaultAsync();
            return result!;
        }
        public async Task<IEnumerable<Customer>> GetByPhoneAsync(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return new List<Customer>();
            }
            var result = await context.Customers.Where(x => x.Phone.ToLower().Equals(phone.ToLower())).ToListAsync();
            return result;
        }
        public async Task<IEnumerable<Customer>> GetByNameSurnameAsync(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return new List<Customer>();
            }
            var result = await context.Customers
                .Where(x => x.Name!.ToLower().StartsWith(characters.ToLower()) || x.Surname1!.StartsWith(characters.ToLower()) || x.Surname2!.StartsWith(characters.ToLower()))
                .ToListAsync();
            return result;
        }
    }
}
