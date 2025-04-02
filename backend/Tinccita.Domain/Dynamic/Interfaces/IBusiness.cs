using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IBusiness
    {
        Task<int> AddAsync(Business entity);
        Task<int> DeleteAsync(Guid id);
        Task<IEnumerable<Business>> GetByDocumentAsync(string document);
        Task<IEnumerable<Business>> GetByEmailAsync(string email);
        Task<Business?> GetByIdAsync(Guid id);
        Task<IEnumerable<Business>> GetByNameAsync(string name);
        Task<IEnumerable<Business>> GetByPhoneAsync(string phone);
        Task<int> UpdateAsync(Business entity);
    }
}
