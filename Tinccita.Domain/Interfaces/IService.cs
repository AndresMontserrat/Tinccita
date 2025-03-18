using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IService
    {
        Task<int> AddAsync(Service entity);
        Task<int> DeleteAsync(Guid id);
        Task<List<Service>> GetAllBySubcategoryAsync(Guid subcategoryId);
        Task<Service?> GetByIdAsync(Guid id);
        Task<List<Service>> GetByTitleDescriptionAsync(string characters);
        Task<int> UpdateAsync(Service entity);
    }
}
