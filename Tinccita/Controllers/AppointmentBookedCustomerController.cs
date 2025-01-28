using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentBookedCustomerController(IAppointmentBookedCustomerService appointmentBookedCustomerService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await appointmentBookedCustomerService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await appointmentBookedCustomerService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateAppointmentBookedCustomer appointmentAvailableCustomer)
        {
            var result = await appointmentBookedCustomerService.AddAsync(appointmentAvailableCustomer);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateAppointmentBookedCustomer appointmentAvailableCustomer)
        {
            var result = await appointmentBookedCustomerService.UpdateAsync(appointmentAvailableCustomer);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await appointmentBookedCustomerService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
