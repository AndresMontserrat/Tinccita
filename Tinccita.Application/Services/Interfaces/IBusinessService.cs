using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Business;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IBusinessService
    {
        Task<GetBusiness> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateBusiness business);
        Task<ServiceResponse> UpdateAsync(UpdateBusiness business);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<List<GetBusiness>> GetByNameAsync(string name, int? number = 3);
        Task<List<GetBusiness>> GetByDocument(string document);
        Task<List<GetBusiness>> GetByEmail(string email);
    }
}
