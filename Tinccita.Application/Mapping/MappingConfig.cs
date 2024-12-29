using AutoMapper;
using Tinccita.Application.DTOs.AppointmentAvailable;
using Tinccita.Application.DTOs.AppointmentBooked;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.DTOs.Business;
using Tinccita.Application.DTOs.Category;
using Tinccita.Application.DTOs.Customer;
using Tinccita.Application.DTOs.Service;
using Tinccita.Application.DTOs.Subcategory;
using Tinccita.Domain.Entities;

namespace Tinccita.Application.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<CreateAppointmentAvailable, AppointmentAvailable>();
            CreateMap<CreateAppointmentBookedCustomer, AppointmentBookedCustomer>();
            CreateMap<CreateAppointmentBooked, AppointmentBooked>();
            CreateMap<CreateBusiness, Business>();
            CreateMap<CreateCategory, Category>();
            CreateMap<CreateCustomer, Customer>();
            CreateMap<CreateService, Service>();
            CreateMap<CreateSubcategory, Subcategory>();

            CreateMap<AppointmentAvailable, GetAppointmentAvailable>();
            CreateMap<AppointmentBookedCustomer, GetAppointmentBookedCustomer>();
            CreateMap<AppointmentBooked, GetAppointmentBooked>();
            CreateMap<Business, GetBusiness>();
            CreateMap<Category, GetCategory>();
            CreateMap<Customer, GetCustomer>();
            CreateMap<Service, GetService>();
            CreateMap<Subcategory, GetSubcategory>();
        }
    }
}
