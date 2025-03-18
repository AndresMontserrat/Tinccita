using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface ICustomer
    {
        Task<int> AddAsync(Customer entity);
        Task<int> DeleteAsync(Guid id);
        Task<Customer?> GetByEmailAsync(string email);
        Task<Customer?> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(Customer entity);
    }
}
