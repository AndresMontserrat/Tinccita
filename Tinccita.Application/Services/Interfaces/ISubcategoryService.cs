using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Subcategory;

namespace Tinccita.Application.Services.Interfaces
{
    public interface ISubcategoryService
    {
        Task<IEnumerable<GetSubcategory>> GetAllAsync();
        Task<GetSubcategory> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateSubcategory subcategory);
        Task<ServiceResponse> UpdateAsync(UpdateSubcategory subcategory);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
