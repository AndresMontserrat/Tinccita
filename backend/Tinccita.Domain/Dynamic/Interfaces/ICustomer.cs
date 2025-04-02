using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface ICustomer
    {
        Task<int> AddAsync(Customer entity);
        Task<int> DeleteAsync(Guid id);
        Task<Customer?> GetByEmailAsync(string email);
        Task<Customer?> GetByIdAsync(Guid id);
        Task<IEnumerable<Customer>> GetByNameSurnameAsync(string characters);
        Task<IEnumerable<Customer>> GetByPhoneAsync(string phone);
        Task<int> UpdateAsync(Customer entity);
    }
}
