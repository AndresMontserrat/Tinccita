using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class SubcategoryRepository(ApplicationDbContext context) : ISubcategory
    {
        public async Task<int> AddAsync(Subcategory entity)
        {
            context.Set<Subcategory>().Add(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<Subcategory>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(Subcategory).Name} with {id} is not found");
            }
            context.Set<Subcategory>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Subcategory>> GetAllAsync()
        {
            var result = await context.Set<Subcategory>().AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Subcategory>> GetAllByCategoryAsync(Guid categoryId)
        {
            var result = await context.Subcategories.Where(x => x.CategoryId.HasValue.Equals(categoryId)).ToListAsync();
            return result!;
        }

        public async Task<Subcategory> GetByIdAsync(Guid id)
        {
            var result = await context.Set<Subcategory>().FindAsync(id);
            return result!;
        }

        public async Task<Subcategory?> GetByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            var result = await context.Subcategories.Where(x => x.Name!.ToLower().Equals(name.ToLower())).FirstOrDefaultAsync();
            return result!;
        }

        public async Task<int> UpdateAsync(Subcategory entity)
        {
            context.Set<Subcategory>().Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
