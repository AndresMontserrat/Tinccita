using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class BusinessRepository(ApplicationDbContext context) : IBusiness
    {
        public async Task<int> AddAsync(Business entity)
        {
            context.Set<Business>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<Business>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(Business).Name} with {id} is not found");
            }
            context.Set<Business>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(Business entity)
        {
            context.Set<Business>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<Business?> GetByIdAsync(Guid id)
        {
            var result = await context.Businesses.FindAsync(id);
            return result!;
        }
        public async Task<IEnumerable<Business>> GetByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<Business>();
            }
            var result = await context.Businesses.Where(x => x.Name!.ToLower().StartsWith(name.ToLower())).ToListAsync();
            return result!;
        }
        public async Task<IEnumerable<Business>> GetByDocumentAsync(string document)
        {
            if (string.IsNullOrEmpty(document))
            {
                return new List<Business>();
            }
            var result = await context.Businesses.Where(x => x.NIF.ToLower().Equals(document.ToLower())).ToListAsync();
            return result!;
        }
        public async Task<IEnumerable<Business>> GetByPhoneAsync(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return new List<Business>();
            }
            var result = await context.Businesses.Where(x => x.Phone.ToLower().Equals(phone.ToLower())).ToListAsync();
            return result!;
        }
        public async Task<IEnumerable<Business>> GetByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return new List<Business>();
            }
            var result = await context.Businesses.Where(x => x.Email.ToLower().Equals(email.ToLower())).ToListAsync();
            return result!;
        }
    }
}
