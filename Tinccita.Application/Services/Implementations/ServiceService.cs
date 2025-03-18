using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Customer;
using Tinccita.Application.DTOs.Service;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class ServiceService(IService serviceInterface, IMapper mapper) : IServiceService
    {
        public async Task<ServiceResponse> AddAsync(CreateService service)
        {
            var mappedData = mapper.Map<Service>(service);
            int result = await serviceInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Service created");
            }
            return new ServiceResponse(false, "Service not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await serviceInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Service deleted");
            }
            return new ServiceResponse(false, "Service not found");
        }

        public async Task<GetService> GetByIdAsync(Guid id)
        {
            var rawData = await serviceInterface.GetByIdAsync(id);
            if (rawData == null) return new GetService();

            return mapper.Map<GetService>(rawData);
        }

        public async Task<List<GetService>> GetAllBySubcategoryAsync(Guid subcategoryId)
        {
            var rawData = await serviceInterface.GetAllBySubcategoryAsync(subcategoryId);
            if (rawData == null) return new List<GetService>();

            return mapper.Map<List<GetService>>(rawData);
        }

        public async Task<List<GetService>> GetByTitleDescriptionAsync(string characters, int? number = 3)
        {
            if (characters.Length < number) return new List<GetService>();
            var rawData = await serviceInterface.GetByTitleDescriptionAsync(characters);
            if (rawData == null) return new List<GetService>();

            return mapper.Map<List<GetService>>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateService service)
        {
            var mappedData = mapper.Map<Service>(service);
            int result = await serviceInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Service updated");
            }
            return new ServiceResponse(false, "Service not found");
        }
    }
}
