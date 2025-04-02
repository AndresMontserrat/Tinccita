using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface ISubcategory
    {
        Task<int> AddAsync(Subcategory entity);
        Task<int> DeleteAsync(Guid id);
        Task<IEnumerable<Subcategory>> GetAllAsync();
        Task<IEnumerable<Subcategory>> GetAllByCategoryAsync(Guid categoryId);
        Task<Subcategory> GetByIdAsync(Guid id);
        Task<Subcategory?> GetByNameAsync(string name);
        Task<int> UpdateAsync(Subcategory entity);
    }
}
