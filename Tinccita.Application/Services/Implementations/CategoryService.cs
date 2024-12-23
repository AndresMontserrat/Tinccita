using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Category;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class CategoryService(IGeneric<Category> categoryInterface, IMapper mapper) : ICategoryService
    {
        public async Task<ServiceResponse> AddAsync(CreateCategory category)
        {
            var mappedData = mapper.Map<Category>(category);
            int result = await categoryInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Category created");
            }
            return new ServiceResponse(false, "Category not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await categoryInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Category deleted");
            }
            return new ServiceResponse(false, "Category not found");
        }

        public async Task<IEnumerable<GetCategory>> GetAllAsync()
        {
            var rawData = await categoryInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetCategory>>(rawData);
        }

        public async Task<GetCategory> GetByIdAsync(int id)
        {
            var rawData = await categoryInterface.GetByIdAsync(id);
            if (rawData == null) return new GetCategory();

            return mapper.Map<GetCategory>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateCategory category)
        {
            var mappedData = mapper.Map<Category>(category);
            int result = await categoryInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Category updated");
            }
            return new ServiceResponse(false, "Category not found");
        }
    }
}
