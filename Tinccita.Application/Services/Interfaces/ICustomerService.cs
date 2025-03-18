using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Customer;

namespace Tinccita.Application.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<GetCustomer> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateCustomer customer);
        Task<ServiceResponse> UpdateAsync(UpdateCustomer customer);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<GetCustomer> GetByEmailAsync(string email);
    }
}
