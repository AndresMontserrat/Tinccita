using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class ServiceRepository(ApplicationDbContext context) : IService
    {
        public async Task<int> AddAsync(Service entity)
        {
            context.Set<Service>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<Service>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(Service).Name} with {id} is not found");
            }
            context.Set<Service>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(Service entity)
        {
            context.Set<Service>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<Service?> GetByIdAsync(Guid id)
        {
            var result = await context.Services.FindAsync(id);
            return result!;
        }
        public async Task<List<Service>> GetByTitleDescriptionAsync(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return new List<Service>();
            }
            var result = await context.Services
                .Where(x => x.Title!.ToLower().StartsWith(characters.ToLower()) || x.Description!.ToLower().StartsWith(characters.ToLower()))
                .ToListAsync();
            return result!;
        }
        public async Task<List<Service>> GetAllBySubcategoryAsync(Guid subcategoryId)
        {
            var result = await context.Services.Where(x => x.SubcategoryId == subcategoryId).ToListAsync();
            return result!;
        }
    }
}
