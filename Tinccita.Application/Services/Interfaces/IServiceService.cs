using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<GetService>> GetAllAsync();
        Task<GetService> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateService customer);
        Task<ServiceResponse> UpdateAsync(UpdateService customer);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
