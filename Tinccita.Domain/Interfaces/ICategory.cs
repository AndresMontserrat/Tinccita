using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface ICategory
    {
        Task<int> AddAsync(Category entity);
        Task<int> DeleteAsync(Guid id);
        Task<List<Category>> GetAllAsync();
        Task<List<Category>> GetByBusinessAsync(Guid businessId);
        Task<Category?> GetByIdAsync(Guid id);
        Task<Category?> GetByNameAsync(string name);
        Task<int> UpdateAsync(Category entity);
    }
}
