using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class BusinessRepository(ApplicationDbContext context) : IBusiness
    {
        private readonly ApplicationDbContext _context;

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
            var result = await _context.Businesses.FindAsync(id);
            return result!;
        }
        public async Task<Business?> GetByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            var result = await _context.Businesses.Where(x => x.Name.ToLower().Equals(name.ToLower())).FirstOrDefaultAsync();
            return result!;
        }
    }
}
