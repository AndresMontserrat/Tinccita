using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class CategoryRepository(ApplicationDbContext context) : ICategory
    {
        public async Task<int> AddAsync(Category entity)
        {
            context.Set<Category>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<Category>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(Category).Name} with {id} is not found");
            }
            context.Set<Category>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(Category entity)
        {
            context.Set<Category>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<Category?> GetByIdAsync(Guid id)
        {
            var result = await context.Categories.FindAsync(id);
            return result!;
        }
        public async Task<Category?> GetByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            var result = await context.Categories.Where(x => x.Name!.ToLower().Equals(name.ToLower())).FirstOrDefaultAsync();
            return result!;
        }
        public async Task<IEnumerable<Category>> GetByBusinessAsync(Guid businessId)
        {
            var result = await context.Categories.Where(x => x.BusinessId.HasValue.Equals(businessId)).ToListAsync();
            return result!;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var result = await context.Categories.ToListAsync();
            return result!;
        }
    }
}
