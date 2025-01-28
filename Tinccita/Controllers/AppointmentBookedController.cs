using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.AppointmentBooked;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentBookedController(IAppointmentBookedService appointmentBookedService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await appointmentBookedService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await appointmentBookedService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateAppointmentBooked appointmentAvailable)
        {
            var result = await appointmentBookedService.AddAsync(appointmentAvailable);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateAppointmentBooked appointmentAvailable)
        {
            var result = await appointmentBookedService.UpdateAsync(appointmentAvailable);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await appointmentBookedService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
