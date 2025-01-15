using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IBusiness
    {
        Task<int> AddAsync(Business entity);
        Task<int> DeleteAsync(Guid id);
        Task<Business?> GetByIdAsync(Guid id);
        Task<Business?> GetByNameAsync(string name);
        Task<int> UpdateAsync(Business entity);
    }
}
