using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Business;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IBusinessService
    {
        Task<IEnumerable<GetBusiness>> GetAllAsync();
        Task<GetBusiness> GetByIdAsync(int id);
        Task<ServiceResponse> AddAsync(CreateBusiness business);
        Task<ServiceResponse> UpdateAsync(UpdateBusiness business);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
