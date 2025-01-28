using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Category;
using Tinccita.Application.DTOs.Subcategory;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class SubcategoryService(ISubcategory subcategoryInterface, IMapper mapper) : ISubcategoryService
    {
        public async Task<ServiceResponse> AddAsync(CreateSubcategory subcategory)
        {
            var mappedData = mapper.Map<Subcategory>(subcategory);
            int result = await subcategoryInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Subcategory created");
            }
            return new ServiceResponse(false, "Subcategory not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await subcategoryInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Subcategory deleted");
            }
            return new ServiceResponse(false, "Subcategory not found");
        }

        public async Task<IEnumerable<GetSubcategory>> GetAllAsync()
        {
            var rawData = await subcategoryInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetSubcategory>>(rawData);
        }

        public async Task<GetSubcategory> GetByIdAsync(Guid id)
        {
            var rawData = await subcategoryInterface.GetByIdAsync(id);
            if (rawData == null) return new GetSubcategory();

            return mapper.Map<GetSubcategory>(rawData);
        }

        public async Task<IEnumerable<GetSubcategory>> GetAllByCategoryAsync(Guid id)
        {
            var rawData = await subcategoryInterface.GetAllByCategoryAsync(id);
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetSubcategory>>(rawData);
        }
        
        public async Task<GetSubcategory> GetByNameAsync(string name)
        {
            var rawData = await subcategoryInterface.GetByNameAsync(name);
            if (rawData == null) return new GetSubcategory();

            return mapper.Map<GetSubcategory>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateSubcategory subcategory)
        {
            var mappedData = mapper.Map<Subcategory>(subcategory);
            int result = await subcategoryInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Subcategory updated");
            }
            return new ServiceResponse(false, "Subcategory not found");
        }
    }
}
