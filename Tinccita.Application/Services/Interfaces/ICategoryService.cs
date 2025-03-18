using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Category;

namespace Tinccita.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<GetCategory>> GetAllAsync();
        Task<GetCategory> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateCategory category);
        Task<ServiceResponse> UpdateAsync(UpdateCategory category);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<GetCategory> GetByNameAsync(string name);
        Task<IEnumerable<GetCategory>> GetAllByBusinessAsync(Guid id);
    }
}
