using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.AppointmentAvailable;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentAvailableController(IAppointmentAvailableService appointmentAvailableService) : ControllerBase
    {
        [HttpGet("all/{id}")]
        public async Task<IActionResult> GetAllByService(Guid id)
        {
            var data = await appointmentAvailableService.GetAllByService(id);
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateAppointmentAvailable appointmentAvailable)
        {
            var result = await appointmentAvailableService.AddAsync(appointmentAvailable);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateAppointmentAvailable appointmentAvailable)
        {
            var result = await appointmentAvailableService.UpdateAsync(appointmentAvailable);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await appointmentAvailableService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
