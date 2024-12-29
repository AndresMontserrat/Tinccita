using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Business;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class BusinessService(IGeneric<Business> businessInterface, IMapper mapper) : IBusinessService
    {
        public async Task<ServiceResponse> AddAsync(CreateBusiness business)
        {
            var mappedData = mapper.Map<Business>(business);
            int result = await businessInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Business created");
            }
            return new ServiceResponse(false, "Business not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await businessInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Business deleted");
            }
            return new ServiceResponse(false, "Business not found");
        }

        public async Task<IEnumerable<GetBusiness>> GetAllAsync()
        {
            var rawData = await businessInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetBusiness>>(rawData);
        }

        public async Task<GetBusiness> GetByIdAsync(Guid id)
        {
            var rawData = await businessInterface.GetByIdAsync(id);
            if (rawData == null) return new GetBusiness();

            return mapper.Map<GetBusiness>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateBusiness business)
        {
            var mappedData = mapper.Map<Business>(business);
            int result = await businessInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Business updated");
            }
            return new ServiceResponse(false, "Business not found");
        }
    }
}
