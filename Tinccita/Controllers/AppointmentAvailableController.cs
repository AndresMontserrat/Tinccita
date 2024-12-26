using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.AppointmentAvailable;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentAvailableController(IAppointmentAvailableService appointmentAvailableService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await appointmentAvailableService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await appointmentAvailableService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(CreateAppointmentAvailable appointmentAvailable)
        {
            var result = await appointmentAvailableService.AddAsync(appointmentAvailable);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateAppointmentAvailable appointmentAvailable)
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
