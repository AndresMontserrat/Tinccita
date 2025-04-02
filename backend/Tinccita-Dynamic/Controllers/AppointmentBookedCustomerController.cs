using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentBookedCustomerController(IAppointmentBookedCustomerService appointmentBookedCustomerService) : ControllerBase
    {
        [HttpGet("find-by-appointment/{id}")]
        public async Task<IActionResult> GetByAppointment(Guid id)
        {
            var data = await appointmentBookedCustomerService.GetAllByAppointmentAsync(id);
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-customer/{id}")]
        public async Task<IActionResult> GetByCustomer(Guid id)
        {
            var data = await appointmentBookedCustomerService.GetAllByCustomerAsync(id);
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
