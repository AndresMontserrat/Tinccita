﻿using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.Customer;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class CustomerService(IGeneric<Customer> customerInterface, IMapper mapper) : ICustomerService
    {
        public async Task<ServiceResponse> AddAsync(CreateCustomer customer)
        {
            var mappedData = mapper.Map<Customer>(customer);
            int result = await customerInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Customer created");
            }
            return new ServiceResponse(false, "Customer not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await customerInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Customer deleted");
            }
            return new ServiceResponse(false, "Customer not found");
        }

        public async Task<IEnumerable<GetCustomer>> GetAllAsync()
        {
            var rawData = await customerInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetCustomer>>(rawData);
        }

        public async Task<GetCustomer> GetByIdAsync(int id)
        {
            var rawData = await customerInterface.GetByIdAsync(id);
            if (rawData == null) return new GetCustomer();

            return mapper.Map<GetCustomer>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateCustomer customer)
        {
            var mappedData = mapper.Map<Customer>(customer);
            int result = await customerInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Customer updated");
            }
            return new ServiceResponse(false, "Customer not found");
        }
    }
}
