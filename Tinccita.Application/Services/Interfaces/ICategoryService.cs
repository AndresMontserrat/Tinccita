using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Category;

namespace Tinccita.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<GetCategory>> GetAllAsync();
        Task<GetCategory> GetByIdAsync(int id);
        Task<ServiceResponse> AddAsync(CreateCategory category);
        Task<ServiceResponse> UpdateAsync(UpdateCategory category);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
